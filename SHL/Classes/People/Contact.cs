namespace SHL.Classes.People
{
    struct Contact
    {
        public string country;
        public string city;
        public string streetType; //ul, al, pl, etc
        public string street;
        public string premisesNumber;
        public string phoneNumber;
        public string email;

        public Contact(string country, string city, string streetType, string street, string premisesNumber, string phoneNumber, string email)
        {
            this.country = country;
            this.city = city;
            this.streetType = streetType;
            this.street = street;
            this.premisesNumber = premisesNumber;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


        public void ChangeContact(string phoneNumber, string email, string country, string city, string streetType, string street, string premisesNumber)
        {
            if (country != null && country != "")
            {
                this.country = country;
            }

            if (city != null && city != "")
            {
                this.city = city;
            }

            if (streetType != null && streetType != "")
            {
                this.streetType = streetType;
            }

            if (street != null && street != "")
            {
                this.street = street;
            }

            if (premisesNumber != null && premisesNumber != "")
            {
                this.premisesNumber = premisesNumber;
            }

            if (phoneNumber != null && phoneNumber != "")
            {
                this.phoneNumber = phoneNumber;
            }

            if (email != null && email != "")
            {
                this.email = email;
            }

        }

        public override string ToString()
        {
            string toReturn = streetType + " " + street + " " + premisesNumber + "/n" + city + ", " + country + "/ntel.: " + phoneNumber + "/neMail: " + email;

            return toReturn;
        }

    }
}