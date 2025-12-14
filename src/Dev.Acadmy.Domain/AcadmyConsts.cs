namespace Dev.Acadmy;

public static class AcadmyConsts
{
    public const string DbTablePrefix = "App";

    public const string DbSchema = "Progres";
}

public static class EducationTypeConsts
{
    public const string PREUNVIRSITY = "PRE-UNVIRSITY";

    public const string UNIVERSITY = "UNIVERSITY";
}
public static class SetPropConsts
{
    public const string CollegeId = "CollegeId";
    public const string AccountTypeId = "AccountTypeId";
    public const string SubjectId = "SubjectId";
    public const string StudentMobileIP = "StudentMobileIP";
    public const string Gender = "Gender";
    public const string UniversityId = "UniversityId";
    public const string GradeLevelId = "GradeLevelId";
    public const string TermId = "TermId";
    public const string PhoneNumber = "PhoneNumber";


}

public static class UserConsts
{
    public const string DefaultImg = "https://i.postimg.cc/SN8rk6M1/download.png";
}
public static class RoleConsts
{
    public const string Student = "Student";
    public const string Teacher = "Teacher";
    public const string Admin = "Admin";
}


public static class AccountTypeConsts
{
    public const string Student = "Student";
    public const string Teacher = "Teacher";
    public const string Admin = "Admin";
}

public static class QuestionTypeConsts
{
    public const string MCQ = "MCQ";
    public const string TrueOrFalse = "TrueOrFalse";
    public const string ShortAnswer = "ShortAnswer";
    public const string CompleteAnswer = "CompleteAnswer";
}

public enum AccountTypeKey
{
    Admin = 1,
    Teacher = 2,
    Student = 3,
}

public enum QuestionTypeEnum
{
    MCQ = 1,
    TrueOrFalse = 2,
    ShortAnswer = 3,
    CompleteAnswer = 4,
}
