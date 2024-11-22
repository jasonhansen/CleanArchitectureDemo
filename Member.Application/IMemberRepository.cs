namespace Member.Application
{
    public interface IMemberRepository
    {
        List<Domain.Member> GetAllMembers();
    }
}
