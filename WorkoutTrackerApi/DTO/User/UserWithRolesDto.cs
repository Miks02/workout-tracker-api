namespace WorkoutTrackerApi.DTO.User;

public class UserWithRolesDto
{
    public string UserId { get; set; } = null!;
    
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;


    public IReadOnlyList<string> Roles { get; set; } = [];
}