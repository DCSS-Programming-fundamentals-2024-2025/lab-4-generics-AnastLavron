using generics.Interfaces;
class Faculty
{
	public int Id;
	public string Name;
	IRepository<Group, int> _groups = new InMemoryRepository<Group, int>();
	public void AddGroup(Group g)
	{
		_groups.Add(g.Id, g);
	}
	public void RemoveGroup(int id)
	{
		_groups.Remove(id);
	}
	public IEnumerable<Group> GetAllGroups()
	{
		return _groups.GetAll();
	}
	public Group GetGroup(int id)
	{
		return _groups.Get(id);
	}
	public void AddStudentToGroup(int groupId, Student s)
	{
		Group G = _groups.Get(groupId);
		G.AddStudent(s);
	}
	public void RemoveStudentFromGroup(int groupId, int studentId)
	{
		Group G = _groups.Get(groupId);
		G.RemoveStudent(studentId);
	}
	public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
	{
		Group G = _groups.Get(groupId);
		return G.GetAllStudents();
	}
	public Student FindStudentInGroup(int groupId, int studentId)
	{
		Group G = _groups.Get(groupId);
		return G.FindStudent(studentId);
	}
}