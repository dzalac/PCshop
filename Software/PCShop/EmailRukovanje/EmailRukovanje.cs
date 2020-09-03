using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailRukovanje
{
    //Ova klasa služi za slanje e-mail poruka na zadane adrese.
    //Postoje dvije funkcije, jedna služi za slanje obavijesti o registraciji, druga za slanje narudžbenice u PDF obliku.
    //Slanje e-maila temelji se na konstruiranju poruke pomoću MailMessage klase. 
    //Poruke se šalju pomoću STMP protokola koji pripada Gmail-u.
    public static class EmailRukovanje
    {
        public static void PosaljiObavijestORegistraciji(string email, string korisnickoIme)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("duckduckdove@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Registracija na DuckDuckDove";
                mail.Body = "<h1 style='text - align:center'>Potvrda o registraciji</h1>" +
                    "<p>Vaša registracija je uspješna. Dobro došli u DuckDuckDove, " + korisnickoIme + "." +
                    "Uživajte u kupnji. :) <br>-DuckDuckDove</p>";
                mail.IsBodyHtml = true;
                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("duckduckdove@gmail.com", "applaud.amplify4.kilobyte");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
            }
        }

        public static void PosaljiNarudzbenicu(MemoryStream ms, string email)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("duckduckdove@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Potvrda o narudžbi";
                mail.Body = "<h1 style='text - align:center'>Potvrda o narudžbi</h1>" +
                    "<p>Dragi kupče, <br> Vaša narudžba je zabilježena. Bit ćete prvom prilikom obaviješteni kada narudžba bude obrađena i poslana. " +
                    "U nastavku možete naći PDF sa informacijama o narudžbi.</p>";
                mail.Attachments.Add(new Attachment(ms, "Narudžbenica.pdf"));
                mail.IsBodyHtml = true;
                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("duckduckdove@gmail.com", "applaud.amplify4.kilobyte");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
            }
        }
    }
}
