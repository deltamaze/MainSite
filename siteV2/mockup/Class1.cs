using System.Collections.Generic;
public class Portfolio
{
    
    string name = "William Pooley";
    string title = "Software Developer";

    string aboutMe =
        @"
            Software developer with over 10 years of professional experience.
            On my free time, I play around with emerging web technologies.
        ";

    List<string> skills = new List<string>(){
            "TSQL",
            "C#",
            ".NET Framework/Core",
            "IIS",
            "Sql Server Administration Tasks",
            "SSRS (Report Development)",
            "SSIS (ETL Services)",
            "HTML 5/CSS",
            "JS Libraries/Frameworks: Bootstrap/React/Angular/Firebase",
        };

    FeaturedApps.Push(
        new FeaturedApp
        {
            Preview = "website.url.com",
            SourceCode = "github.com/",
            Description = 
            @"
                Timer/Stop watch website built with C# Blazor
                Targetting Web Assembly, to run natively on client computer
            "
        });

    FeaturedApps SimplePlanner =
        new FeaturedApps
        {
            Preview = "planner.wpooley.com", //Display with HTML a tag: "View" with href to actual
            SourceCode = "github.com/",
            Description =
            @"
                Planner/Calendar website built with Redux/React/Firebase.
            "
        };

    FeaturedApps PrivacyScreen =
        new FeaturedApps
        {
            Preview = "planner.wpooley.com",
            SourceCode = "github.com/",
            Description =
            @"
                Planner/Calendar website built with Redux/React/Firebase.
            "
        };

    

    ///////////////////////////////////////////////////////////////////////////
    ///                          Other Coding Projects                      ///
    ///
    /// Project Name:
    /// Project Type:
    /// Description:
    /// Github:
    /// 
    /// Project Name:
    /// Project Type:
    /// Description:
    /// Github:
    /// 
    /// Project Name:
    /// Project Type:
    /// Description:
    /// Github:
}


public class FeaturedApp
{
    public string Preview { get; set; }
    public string SourceCode{ get; set; }
    public string Description { get; set; }
}
public class Portfolio
{
    public List<FeaturedApp> FeaturedApps { get; set; }

}