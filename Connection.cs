using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp01
{
    internal class Connection
    {
        // ១. ផ្លូវតភ្ជាប់ (សូមដូរពាក្យ "ឈ្មោះ_Database_របស់អ្នក" ទៅជាឈ្មោះ Database ពិតប្រាកដរបស់អ្នក)
        public static string conStr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=MICROLAON;Integrated Security=True;TrustServerCertificate=True";
        // 🚨 ឱ្យគាត់ដូរបន្ទាត់ conStr មកជាបែបនេះវិញ៖
        //public static string conStr = @"Data Source=MAMAMILA\SQLEXPRESS;Initial Catalog=MICROLOAN;Integrated Security=True;TrustServerCertificate=True";
        // ២. បង្កើត Object SqlConnection ឈ្មោះ conn (កូដចាស់របស់អ្នកខ្វះបន្ទាត់នេះ ទើបវា Error 'conn')
        public static SqlConnection conn = new SqlConnection(conStr);
    }
}
