using System;
using MoltenMotelLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoltenMotelTest {
    [TestClass]
    public class MotelTest {
        [TestMethod]
        public void TemperatureSetStatus() {
            Room room = new Room(0, 701);

            int expected = (int)eRoomTemp.BURNEDOUT;

            int actual = (int)room.roomStatus;

            Assert.AreEqual(expected, actual, 0.001 ,"Room status is not BURNEDOUT");
        }
        [TestMethod]
        public void TemperatureSetStatusFail() {
            Room room = new Room(0, 690);

            int expected = (int)eRoomTemp.BURNEDOUT;

            int actual = (int)room.roomStatus;

            Assert.AreEqual(expected, actual, 0.001, "Room status is not BURNEDOUT");
        }
        [TestMethod]
        public void CoolantTest() {

            Truck truck = new Truck();

            truck.coolant = 80;
            truck.truckStatus = eFiretruckStatus.ONCALL;

            int expected = 40;
            
            truck.tick();
            int actual = truck.coolant;
            Assert.AreEqual(expected, actual, 0.001, "Coolant level is not 40");

        }
        [TestMethod]
        public void CoolantTestFail() {

            Truck truck = new Truck();

            truck.coolant = 50;
            truck.truckStatus = eFiretruckStatus.ONCALL;

            int expected = 40;

            truck.tick();
            int actual = truck.coolant;
            Assert.AreEqual(expected, actual, 0.001, "Coolant level is not 40");

        }
        [TestMethod]
        public void RoomBuildTest() {
            int noRooms = 12;
            Motel motel = new Motel(noRooms);
            int expected = noRooms;

            int actual = motel.numberOfRooms();
            Assert.AreEqual(expected, actual, 0.001, "The number of rooms is not expected");

        }
        [TestMethod]
        public void RoomBuildTestFail() {
            int noRooms = 0;
            Motel motel = new Motel(noRooms);
            int expected = noRooms;

            int actual = motel.numberOfRooms();
            Assert.AreEqual(expected, actual, 0.001, "The number of rooms is not expected");

        }
        [TestMethod]
        public void OneFireTest() {
            int noRooms = 12;
            Motel motel = new Motel(noRooms);
            int expected = 1;
            int actual = 0;
            for (int i = 0; i < motel.rooms.Count; i++)
            {
                if (motel.rooms[i].onFire) { actual++; }
            }
            
            Assert.AreEqual(expected, actual, 0.001, "Number of rooms on fire is not 1");

        }
        [TestMethod]
        public void OneFireTestFail() {
            int noRooms = 0;
            Motel motel = new Motel(noRooms);
            int expected = 1;
            int actual = 0;
            for (int i = 0; i < motel.rooms.Count; i++) {
                if (motel.rooms[i].onFire) { actual++; }
            }

            Assert.AreEqual(expected, actual, 0.001, "Number of rooms on fire is not 1");

        }
        [TestMethod]
        public void TruckRefillTest() {
            Truck truck = new Truck();
            truck.truckStatus = eFiretruckStatus.STATIONED;
            truck.coolant = 0;

            int expected = 600;

            truck.refill();

            int actual = truck.coolant;
            Assert.AreEqual(expected, actual, 0.001, "The coolant is not 600");
        }

        [TestMethod]
        public void TruckRefillTestFail() {
            Truck truck = new Truck();
            truck.truckStatus = eFiretruckStatus.FREE;
            truck.coolant = 0;

            int expected = 600;

            truck.refill();

            int actual = truck.coolant;
            Assert.AreEqual(expected, actual, 0.001, "The coolant is not 600");
        }
    }
}
