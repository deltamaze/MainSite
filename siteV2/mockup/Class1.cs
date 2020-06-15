using System.Collections.Generic;
public class WilliamPooley : SoftwareDeveloper
{
    void MyInfo()
    {
        AboutMe =
        @"
            Software developer with over 10 years of professional experience.
            On my free time, I play around with emerging web technologies.
        ";

        Skills = new List<string>(){
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

        FeaturedApps = new List<FeaturedApp>() {
        new FeaturedApp()
        {
            Name = "BlazorTimer",
            Preview = "website.url.com", //swap with hypertext link
            SourceCode = "github.com/",
            Description =
            @"
                Timer/Stop watch website built with C# Blazor
                Targetting Web Assembly, to run natively on client computer
            "
        },

        new FeaturedApp()
        {
            Name = "ReactPlanner",
            Preview = "website.url.com",//swap with hypertext link
            SourceCode = "github.com/",
            Description =
            @"
                Persistent Planner/Calendar website built with Redux/React/Firebase.
            "
        },

        new FeaturedApp()
        {
            Name = "Privacy Screen",
            Preview = "website.url.com",//swap with hypertext link
            SourceCode = "github.com/",
            Description =
            @"
                Chrome Extension, only displays browser content while mouse is
                hovering viewport. Applies a blank screen when mouse is no
                longer hovering over viewport.
            "
        }
    };

        AroundTheWeb = new Dictionary<string, string>()
        {
            { "LinkedIn","github.com" },
            { "Github","github.com" },
            { "Github","github.com" }
        };
    }
}






public class FeaturedApp
{
    public string Name { get; set; }
    public string Preview { get; set; }
    public string SourceCode { get; set; }
    public string Description { get; set; }
}
public class SoftwareDeveloper
{
    public List<FeaturedApp> FeaturedApps = new List<FeaturedApp>();
    public string AboutMe { get; set; }

    public List<string> Skills { get; set; }
    public Dictionary<string, string> AroundTheWeb = new Dictionary<string, string>();

}