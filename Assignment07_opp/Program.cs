namespace Assignment07_opp
{
    internal class Program
    {
        static void Main()
        {
            // part 01


                    //q1: b) To define a blueprint for a class

                    //q2: a) private

                    //q3: b) No

                    //q4: b) Yes, interfaces can inherit from multiple interfaces

                    //q5: d) implements

                    //q6: a) Yes

                    //q7: b) No, all members are implicitly public

                    //q8: a) To hide the interface members from outside access

                    //q9:  b) No, interfaces cannot have constructors

                    //q10: c) By separating interface names with commas


            // part 02
            #region q1: Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.


            //ICircle circle = new Circle(3.0);
            //IRectangle rectangle = new Rectangle(3.0, 5.0);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion


            #region q2: 


            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "alice";
            //string password = "password123";
            //string role = "Admin";

            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("User authenticated.");

            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine("User authorized.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("User not authorized.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}



            #endregion



            #region q3:

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "moeldeghiedy@gmail.com";
            //string message = "Your order has been shipped.";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification("+201017825816", message);
            //pushService.SendNotification("DeviceToken123", message);


            #endregion
        }
    }
}
