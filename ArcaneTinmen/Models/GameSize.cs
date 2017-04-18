namespace ArcaneTinmen.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gamesize")]
    public partial class GameSize
    {
        public int GameSizeId { get; set; }

        public int SizeId { get; set; }

        public int GameId { get; set; }

        public virtual Games Games { get; set; }

        public virtual Size Size { get; set; }

        //Constructors
        public GameSize(int gamesizeid, int sizeid, int gameid)
        {
            GameSizeId = gamesizeid;
            SizeId = sizeid;
            GameId = gameid;
        }

        public GameSize()
        {
            
        }
    }
}
