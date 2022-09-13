using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }

        static TicketService()
        {
            Tickets = new List<Ticket> {
            new Ticket{ID=1, BookedFor="platinumPlus",Price=5000,Qty=200},
             new Ticket{ID=11, BookedFor="platinum",Price=5000,Qty=200},
              new Ticket{ID=12, BookedFor="Gold",Price=5000,Qty=200},
               new Ticket{ID=13, BookedFor="Silver",Price=5000,Qty=200},
                new Ticket{ID=14, BookedFor="General",Price=5000,Qty=200}
                };
        }
        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.ID == id);
            return ticket;
        }




        }
    }

