using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZodiacHockey.Data;

namespace ZodiacHockey.Services
{
    public class PlayerRepository:IPlayerRepository
    {
        private Context _context;
        public PlayerRepository(Context context)
        {
            _context = context;
        }

        public void SavePosition()
        {
            var position = new Team
            {
                TeamAbreviationId = "WSH",
                Division = "Metro",
                City = "Washington",
                TeamName = "Capitals"
            };

            _context.Teams.Add(position);
            _context.SaveChanges();
        }
    }
}
