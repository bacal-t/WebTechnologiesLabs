using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarpentyStore2.Domain.Abstract
{
    public interface IDoorRepository
    {
        IQueryable<Door> Doors { get; }
        IQueryable<Land> Lands { get; }
        IQueryable<Armchair> Armchairs { get; }
        IQueryable<Table> Tables { get; }

        void SaveLand(Land land);
        void SaveDoor(Door door);
        void SaveArmchair(Armchair armchair);
        void SaveTable(Table table);
        Door DeleteDoor(int DoorId);
        Land DeleteLand(int LandId);
        Armchair DeleteArmchair(int ArmchairId);
        Table DeleteTable(int TableId);
    }
}
