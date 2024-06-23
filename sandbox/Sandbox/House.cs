
class House
{
    private List<Room> rooms = new();

    public House(List<Room> rooms) {
        // foreach (Room room in rooms) {
        //     this.rooms.Add(room);
        // }
        this.rooms = rooms;
    }

    public List<Room> GetRooms() {
        return rooms;
    }
}