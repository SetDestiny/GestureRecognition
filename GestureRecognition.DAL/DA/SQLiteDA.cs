using GestureRecognition.DAL.Models;
using GestureRecognition.Helpers.Logs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace GestureRecognition.DAL.DataAccess
{
    public class SQLiteDA
    {
        private SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(Constants.ConnectonString);
            try
            {
                LogHelper.MessageToLog(string.Format("Try to get connection to '{0}' database.", Constants.ConnectonString));
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                LogHelper.MessageToLog(string.Format("Error '{0}'", ex.Message));
                throw ex;
            }

            if (conn.State == ConnectionState.Open)
            {
                LogHelper.MessageToLog(string.Format("Connected to '{0}' database successfully.", conn.FileName));
                return conn;
            }
            else
            {
                conn.Dispose();
                return null;
            }
        }

        public void InsertGesture(Gesture gesture)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                LogHelper.MessageToLog("Try to insert gesture to database.");

                SQLiteCommand cmd = conn.CreateCommand();
                string sql_command = string.Format(
                    "INSERT INTO tbGestures(gestureName, gestureArea, gestureCompactness, gesturePx, gesturePy) " +
                    "VALUES (\"{0}\",{1},{2},{3},{4});",
                    gesture.Name, gesture.Area.ToString().Replace(',', '.'), gesture.Compactness.ToString().Replace(',', '.'), gesture.Px.ToString().Replace(',', '.'), gesture.Py.ToString().Replace(',', '.'));

                cmd.CommandText = sql_command;
                try
                {
                    cmd.ExecuteNonQuery();
                    LogHelper.MessageToLog("Gesture successfully inserted to database.");
                }
                catch (SQLiteException ex)
                {
                    LogHelper.MessageToLog(string.Format("Add gesture to database failed with exeption '{0}'.", ex.Message));
                    throw ex;
                }
            }
        }

        public List<Gesture> GetGestures()
        {
            using (SQLiteConnection conn = GetConnection())
            {
                List<Gesture> list = new List<Gesture>();
                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT id, gestureName, gestureArea, gestureCompactness, gesturePx, gesturePy FROM tbGestures";
                try
                {
                    LogHelper.MessageToLog(string.Format("Try to get gestures from database '{0}'.", conn.FileName));
                    SQLiteDataReader r = cmd.ExecuteReader();
                    string line = String.Empty;
                    while (r.Read())
                    {
                        var tmp = new Gesture();

                        tmp.Id = Convert.ToInt32(r["id"]);
                        tmp.Name = r["gestureName"].ToString();
                        tmp.Area = Convert.ToDouble(r["gestureArea"]);
                        tmp.Compactness = Convert.ToDouble(r["gestureCompactness"]);
                        tmp.Px = Convert.ToDouble(r["gesturePx"]);
                        tmp.Py = Convert.ToDouble(r["gesturePy"]);

                        list.Add(tmp);
                    }
                    r.Close();

                    LogHelper.MessageToLog(string.Format("Gestures from database successfully retrieved in count of {0}.", list.Count));
                    return list;
                }
                catch (SQLiteException ex)
                {
                    LogHelper.MessageToLog(string.Format("Gestures from database failed to retrieve with exeption '{0}'.", ex.Message));
                    return list;
                }
            }
        }
    }
}
