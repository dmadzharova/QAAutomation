namespace Homework
{
    public static class UserFactory
    {

        public static RegistrationUser CreateValidUser()
        {
            
            return new RegistrationUser
            {
                FirstName = "Ivan",
                LastName = "Petrov",
                Password = "fdafaf",
                Date = "12",
                Year = "1990",
                Month = "4",
                Gender = "male",
                RealFirstName = "Ivan",
                RealLastName = "Petroff",
                Company = "QA Service",
                Address = "11 Mason St",
                City = "San Francisco",
                State = "5",
                Zip = "94130",
                Phone = "4159873845",
                Alias = "Work"
            };
        }
    }
}
