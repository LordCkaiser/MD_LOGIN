using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MD_LOGIN.Conexion
{
    class Tamaño_automatio_de_datatable
    {
         public static void Multilinea(ref DataGridView list)
        {
            list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            list.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            list.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            list.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            list.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.White;
            styCabeceras.ForeColor = System.Drawing.Color.Black;
            styCabeceras.Font = new System.Drawing.Font("Metropolis", 12, System.Drawing.FontStyle.Bold);
            list.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
    }
}
