using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FigSquareTEST
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Figura circle = new Circle("","", "");
            Figura triangle= new Triangle("", "", "");
            
            
            Console.WriteLine(circle.SquareFig(s));
            Console.WriteLine(triangle.SquareFig(s));
            Console.ReadKey();
        }
        
    }
}
