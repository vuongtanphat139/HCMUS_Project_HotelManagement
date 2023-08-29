using DAO_HotelManagement;
using DTO_HoTelManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_HotelManagement
{
    public class Room_BUS
    {
        public static List<string> getListRoom()
        {
            return Room_DAO.Instance.getListRoom();
        }
        public static List<string> getListRoom(string filterStatus, string filterType)
        {
            return Room_DAO.Instance.getListRoom(filterStatus, filterType);
        }
        public static List<string> getListFRoom(string floor)
        {
            return Room_DAO.Instance.getListFRoom(floor);
        }
        public static DataTable getRoomService(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomService(RoomName);
        }
        public static DataTable getRoomService_Bus(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomService_Bus(RoomName);

        }
        public static DataTable getRoomService_Sub(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomService_Sub(RoomName);
        }
        public static string getRoomStatus(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomStatus(RoomName);
        }
        public static List<string> getListRoom_Status(string filterStatus, string filterType)
        {
            return Room_DAO.Instance.getListRoomFilter_Status(filterStatus, filterType);
        }
        public static List<string> getListRoom_Type(string filterStatus, string filterType)
        {
            return Room_DAO.Instance.getListRoomFilter_Type(filterStatus, filterType);
        }
        public static string getRoomInformation(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomInformation(RoomName);
        }
        public static string getCustomerRoomInformation(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getCustomerRoomInformation(RoomName);
        }
        public static string getRoomPrice(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomPrice(RoomName);
        }
        public static DataTable getRoomItems(Room_DTO RoomName)
        {
            return Room_DAO.Instance.getRoomItems(RoomName);
        }
        public static bool updatePriceRoom(Room_DTO RoomName)
        {
            return Room_DAO.Instance.updatePriceRoom(RoomName);
        }
        public static List<string> getListItems(Room_DTO RoomInfo)
        {
            return Room_DAO.Instance.getListItems(RoomInfo);
        }
        public static bool updateStatusRoom(Room_DTO RoomName, string newStatus)
        {
            return Room_DAO.Instance.updateStatusRoom(RoomName, newStatus);
        }
    }
}