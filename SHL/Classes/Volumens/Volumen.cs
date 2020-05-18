using SHL.Classes.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHL.Classes.Volumens
{
    class Volumen
    {
        private string title;
        private string originalTitle;
        private string subtitle;
        private string originalSubtitle;
        private string authorsName;
        private string authorsSurname;
        private string publishingHouse;
        private int publishingYear;
        private string ean;
        private string type;
        private int edition;
        private string originalLanguage;
        private string translatorsName;
        private string translatorsSurname;
        private decimal punishmentForDetention;
        private string location;
        private bool borrowed;
        private List<Customer> rentalHistory;

       

        public void ChangeLocation(string location)
        {
            this.location = location;
        }

        public void ChangePunishment(decimal punishment)
        {
            punishmentForDetention = punishment;
        }

        public void StartBorrow(Customer customer)
        {
            borrowed = true;
            rentalHistory.Add(customer);
        }

        public void EndBorrow()
        {
            borrowed = false;
        }

        public void CorrectData(
            string title,
            string originalTitle,
            string subtitle,
            string originalSubtitle,
            string authorsName,
            string authorsSurname,
            string publishingHouse,
            int publishingYear,
            string ean,
            string type,
            int edition,
            string originalLanguage,
            string translatorsName,
            string translatorsSurname,
            decimal punishmentForDetention,
            string location,
            bool borrowed,
            List<Customer> rentalHistory)
        {
            this.title = title;
            this.originalTitle = originalTitle;
            this.subtitle = subtitle;
            this.originalSubtitle = originalSubtitle;
            this.authorsName = authorsName;
            this.authorsSurname = authorsSurname;
            this.publishingHouse = publishingHouse;
            this.publishingYear = publishingYear;
            this.ean = ean;
            this.type = type;
            this.edition = edition;
            this.originalLanguage = originalLanguage;
            this.translatorsName = translatorsName;
            this.translatorsSurname = translatorsSurname;
            this.punishmentForDetention = punishmentForDetention;
            this.location = location;
            this.borrowed = borrowed;
            this.rentalHistory = rentalHistory;
        }
    }
}
