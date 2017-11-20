using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*1. Write a function that accepts an array of non-negative integers and returns the second largest integer in the array.
 Return -1 if there is no second largest.
The signature of the function is 
int f(int[] a)

Examples:
if the input array is:	return:
{1, 2, 3, 4}	           3
{{4, 1, 2, 3}}	         3
{1, 1, 2, 2}	           1
{1, 1}	                -1
{1}                    -1
{}	                    -1
*/
namespace ArrayOfnonNegativeInterger
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             a1(new int[] { 1, 2, 3, 4 });
             a1(new int[] { 4, 1, 2, 3 });
             a1(new int[] { 1, 1, 2, 2 });
             a1(new int[] { 1, 1});
             a1(new int[] {1});
             a1(new int[] {});

            

        }

       public int a1(int[] a)
        {
            int max1 = -1;
            int max2 = -1;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max1)
                {
                      
                    max1 = a[i];
                    max2 = max1;
                }
                else if (a[i] != max1 && a[i] > max2)
                    max2 = a[i];
            }

            return max2;
            
        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
            int[] a = new int[0];
            ResultLabel.Text = a1(a).ToString(); 
        }
    }
}
