using System;

using UIKit;

namespace BMIIOSDevProject
{
    public partial class ViewController : UIViewController
    {
        partial void Clear_TouchUpInside(UIButton sender)
        {
            height.Text = "";
            weight.Text = "";
            result.Text = "";
            category.Text = "";
            inch.Text = "";
            severe.TextColor = UIColor.Black;
            severe1.TextColor = UIColor.Black;
            moderate.TextColor = UIColor.Black;
            moderate2.TextColor = UIColor.Black;
            mild.TextColor = UIColor.Black;
            mild2.TextColor = UIColor.Black;
            normal.TextColor = UIColor.Black;
            normal2.TextColor = UIColor.Black;
            over.TextColor = UIColor.Black;
            over2.TextColor = UIColor.Black;
            obe1.TextColor = UIColor.Black;
            obec1.TextColor = UIColor.Black;
            obe2.TextColor = UIColor.Black;
            obec2.TextColor = UIColor.Black;
            obe3.TextColor = UIColor.Black;
            obec3.TextColor = UIColor.Black;
        }

        partial void Compute_TouchUpInside(UIButton sender)
        {
            double ft = Convert.ToDouble(height.Text);
            double lbs = Convert.ToDouble(weight.Text);
            double inches = Convert.ToDouble(inch.Text);
            double meters = Convert.ToDouble(ft * 0.3048);
            double kilograms = Convert.ToDouble(lbs * 0.454);
            double inchToMeters = Convert.ToDouble(inches * 0.0254);
            double mtrs = meters + inchToMeters;


            double BMI = kilograms / (mtrs * mtrs);
            result.Text = Convert.ToString(BMI);
            if (BMI < 16){
                category.Text = "Severe Thinness";
                severe.TextColor = UIColor.Blue;
                severe1.TextColor = UIColor.Blue;
            }
            else if(BMI < 17){
                category.Text = "Moderate Thinness";
                moderate.TextColor = UIColor.Blue;
                moderate2.TextColor = UIColor.Blue;
            }
            else if(BMI < 18.5){
                category.Text = "Mild Thinness";
                mild.TextColor = UIColor.Blue;
                mild2.TextColor = UIColor.Blue;
            }
            else if (BMI < 25){
                category.Text = "Normal";
                normal.TextColor = UIColor.Green;
                normal2.TextColor = UIColor.Green;
            }
            else if (BMI < 30){
                category.Text = "Overweight";
                over.TextColor = UIColor.Green;
                over2.TextColor = UIColor.Green;   
            }
            else if (BMI < 35){
                category.Text = "Obese Class 1";
                obe1.TextColor = UIColor.Red;
                obec1.TextColor = UIColor.Red;
            }
            else if (BMI < 40){
                category.Text = "Obese Class 2";
                obe2.TextColor = UIColor.Red;
                obec2.TextColor = UIColor.Red;
            }
            else {
                category.Text = "Obese Class 3";
                obe3.TextColor = UIColor.Red;
                obec3.TextColor = UIColor.Red;
            }

        }


        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
