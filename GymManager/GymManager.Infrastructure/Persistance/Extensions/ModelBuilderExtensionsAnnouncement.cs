using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtensionsAnnouncement
{
    public static void SeedAnnouncement(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcement>().HasData(
            new Announcement
            {
                Id = 1,
                Date = new DateTime(2022, 9, 12),
                Description = "Kod promocyjny na w sklepie abc = rabat12."
            },
            new Announcement
            {
                Id = 2,
                Date = new DateTime(2022, 10, 12),
                Description = "Silownia otwarta w niedziele"
            }, new Announcement
            {
                Id = 3,
                Date = new DateTime(2022, 11, 12),
                Description = "Otwieramy jutro zapraszamy wszystkich serdecznie"
            }, new Announcement
            {
                Id = 4,
                Date = new DateTime(2022, 5, 12),
                Description = "Crossfit jutro odwolany przepraszamy"
            }, new Announcement
            {
                Id = 5,
                Date = new DateTime(2022, 2, 12),
                Description = "Jutro przyjezdza do nas nowy sprzet zapraszamy na probe."
            }, new Announcement
            {
                Id = 6,
                Date = new DateTime(2022, 1, 12),
                Description = "Oferta pracy dla trenera parsonalnego, zapraszamy do zostawienia CV w recepcji"
            }, new Announcement
            {
                Id = 7,
                Date = new DateTime(2022, 6, 12),
                Description = "Zatrudnimy asystentke na recepcje"
            }, new Announcement
            {
                Id = 8,
                Date = new DateTime(2022, 5, 12),
                Description = "Szukamy nowych klientow zapraszamy bardzo serdeczenie"
            }, new Announcement
            {
                Id = 9,
                Date = new DateTime(2022, 1, 12),
                Description = "Potrzebny informatyk do utrzymania naszej strony internetowej, jesli potrafisz takie rzeczy pisz na priv"
            }, new Announcement
            {
                Id = 10,
                Date = new DateTime(2022, 4, 12),
                Description = "Promocja na naszej silowni, zapraszamy, tylko w tym miesiacu tansze karnety"
            }, new Announcement
            {
                Id = 11,
                Date = new DateTime(2022, 3, 12),
                Description = "Darmowy trening z trenerem personalnym tylko w dniu jutrzejszym"
            },
            new Announcement
            {
                Id = 12,
                Date = new DateTime(2022, 2, 12),
                Description = "Kod znizkowy na diete u naszego trenera znajdziesz u nas w recepcji zapraszamy po odbior"
            }
            );
    }
}
