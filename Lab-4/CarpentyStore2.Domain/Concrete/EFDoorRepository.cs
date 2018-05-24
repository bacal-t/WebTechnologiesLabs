using CarpentyStore2.Domain.Abstract;
using CarpentyStore2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpentyStore2.Domain.Concrete
{
    public class EFDoorRepository : IDoorRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Door> Doors
        {
            get { return context.Doors; }
        }

        public IQueryable<Land> Lands
        {
            get { return context.Lands; }
        }

        public IQueryable<Armchair> Armchairs
        {
            get { return context.Armchairs; }
        }

        public IQueryable<Table> Tables
        {
            get { return context.Tables; }
        }

        // Сохраняем изменения в таблице Doors
        public void SaveDoor(Door door)
        {
            if (door.DoorId == 0)
            {
                context.Doors.Add(door);
            }
            else
            {
                Door dbEntry = context.Doors.Find(door.DoorId);
                if (dbEntry != null)
                {
                    dbEntry.TypeDoor = door.TypeDoor;
                    dbEntry.Tree = door.Tree;
                    dbEntry.Price = door.Price;
                    dbEntry.ImageData = door.ImageData;
                    dbEntry.ImageMimeType = door.ImageMimeType;
                }
            }
            context.SaveChanges();
        }

        // Удаляем запись из таблицы Doors
        public Door DeleteDoor(int DoorId)
        {
            Door dbEntry = context.Doors.Find(DoorId);
            if (dbEntry != null)
            {
                context.Doors.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        // Сохраняем изменения в таблице Land.
        public void SaveLand(Land land)
        {
            if (land.LandId == 0)
            {
                context.Lands.Add(land);
            }
            else
            {
                Land dbEntry = context.Lands.Find(land.LandId);
                if (dbEntry != null)
                {
                    dbEntry.TypeOfLand = land.TypeOfLand;
                    dbEntry.Tree = land.Tree;
                    dbEntry.Price = land.Price;
                    dbEntry.ImageData = land.ImageData;
                    dbEntry.ImageMimeType = land.ImageMimeType;
                }                
            }
            context.SaveChanges();
        }

        // Удаляем запись из таблицы Doors
        public Land DeleteLand(int LandId)
        {
            Land dbEntry = context.Lands.Find(LandId);
            if (dbEntry != null)
            {
                context.Lands.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        // Сохраняем изменения в таблице Armchairs
        public void SaveArmchair(Armchair armchair)
        {
            if (armchair.ArmchairId == 0)
            {
                context.Armchairs.Add(armchair);
            }
            else
            {
                Armchair dbEntry = context.Armchairs.Find(armchair.ArmchairId);
                if (dbEntry != null)
                {
                    dbEntry.TypeOfArmchair = armchair.TypeOfArmchair;
                    dbEntry.Tree = armchair.Tree;
                    dbEntry.Price = armchair.Price;
                    dbEntry.ImageData = armchair.ImageData;
                    dbEntry.ImageMimeType = armchair.ImageMimeType;
                }
               
            }
            context.SaveChanges();
        }

        // Удаляем запись из таблицы Armchairs
        public Armchair DeleteArmchair(int ArmchairId)
        {
            Armchair dbEntry = context.Armchairs.Find(ArmchairId);
            if (dbEntry != null)
            {
                context.Armchairs.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        // Сохраняем изменения в таблице 
        public void SaveTable(Table table)
        {
            if (table.TableId == 0)
            {
                context.Tables.Add(table);
            }
            else
            {
                Table dbEntry = context.Tables.Find(table.TableId);
                if (dbEntry != null)
                {
                    dbEntry.TypeOfTable = table.TypeOfTable;
                    dbEntry.Tree = table.Tree;
                    dbEntry.Price = table.Price;
                    dbEntry.ImageData = table.ImageData;
                    dbEntry.ImageMimeType = table.ImageMimeType;
                }                
            }
            context.SaveChanges();
        }

        // Удаляем запись из таблицы Tables
        public Table DeleteTable(int TableId)
        {
            Table table = context.Tables.Find(TableId);
            if (table != null)
            {
                context.Tables.Remove(table);
                context.SaveChanges();
            }
            return table;
        }

    }
}
