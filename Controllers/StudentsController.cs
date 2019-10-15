using System;
using System.Collections.Generic;
using System.Linq;
using Tuto7.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using System.Data.SqlClient;

namespace Tuto7.Controllers
{
    public class StudentsController : Controller
    {


        public string SaveStd(Student student)
        {
          
              SqlConnection connection = new SqlConnection(@"Server=DESKTOP-059A10P\SQLEXPRESS;Database=ASPCRUD;Integrated Security=true;");

            connection.Open();
            string query = "INSERT INTO Contact2(Name, Mobile)VALUES('" + student.Name+"','"+student.Mobile+"')";
            SqlCommand cmd = new SqlCommand(query, connection);

            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {


                return "save data success";
            }

                return "failed";


            

        }
    }

}