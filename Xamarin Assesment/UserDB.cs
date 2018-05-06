using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace Xamarin_Assesment
{
    class UserDB
    {

        //private string _pathToDatabase = "Resources/database/Users.db";
        private SQLiteConnection _connection;
        
        /**
         * DEV: Joshua Lopes
         * DESC: Insert Query that takes new user login and updates existing SQLite DB
         */
        protected void InsertIntoDB()
        {

        }

        /**
         * DEV: Joshua Lopes
         * DESC: Select Query that returns user logins and shows them on UI
         */
        protected void GetLogins()
        {

        }
    }
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}