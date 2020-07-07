public class RoomClass
{
	public string RoomName;

	public RoomClass(string RoomName)
	{
		this.RoomName = RoomName;
	}

	public string WhichRoom()
	{
		return "The room name is " +  Roomname;
	}
	
	public string Roomname
	{
		get { return color; }
		set{color = value; }
	}
}
