using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bug_Tracker.Forms.DB;
using Oracle.ManagedDataAccess.Client;
using Bug_Tracker.Forms.Model;

namespace BugTrackerTest
{
    [TestClass]
    public class TestInsert
    {
       

       

        [TestMethod]
        public void InsertUser()
        {
            int expected = 1;
            Bug_Tracker.Forms.Model.UserTable us = new Bug_Tracker.Forms.Model.UserTable()
             {
                 fname = "Savnjeev",
                 lname = "Thapa",
                 contact = "4583456",
                 address = "Banepa",
                 username = "iron",
                 password = "man",
                 type_id = 1


             };
            Bug_Tracker.Forms.DAO.UserDAO user = new Bug_Tracker.Forms.DAO.UserDAO();
            int result = user.Insert(us);
            Assert.AreEqual(expected, result);

    }

        [TestMethod]
        public void InsertBug()
        {
            int expected = 11;
            Bug_Tracker.Forms.Model.Bug us = new Bug_Tracker.Forms.Model.Bug()
            {
                program = 5,
                method_name = "main",
                class_name = "Error",
                line_number = 20,
               found_by=6,
               
                


            };
            Bug_Tracker.Forms.DAO.BugDAO bug = new Bug_Tracker.Forms.DAO.BugDAO();
            int result = bug.Insert(us);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void Update()
        {
            int expected = 1;
            Bug_Tracker.Forms.Model.UserTable us = new Bug_Tracker.Forms.Model.UserTable()
            {
                password = "pass",
                user_id = 7


            };
            Bug_Tracker.Forms.DAO.UserDAO user = new Bug_Tracker.Forms.DAO.UserDAO();
            int result = user.Update(us);
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void InsertProgram()
        {
            int expected = 1;
            Bug_Tracker.Forms.Model.Programs us = new Bug_Tracker.Forms.Model.Programs()
            {
                program_name = "Bug Track",
                language="cSharp"



            };
            Bug_Tracker.Forms.DAO.ProgramDAO user = new Bug_Tracker.Forms.DAO.ProgramDAO();
            int result = user.Insert(us);
            Assert.AreEqual(expected, result);

        }


    }
}
