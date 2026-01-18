using portfolio_v2.Enums;

namespace portfolio_v2.Helpers;

public static class TechMap
{

    public static string Icon(ETech eTech) => eTech switch
    {
        ETech.Access => "imgs/projects/stack/access.svg",
        ETech.Azure => "imgs/projects/stack/azure.svg",
        ETech.CSharp => "imgs/projects/stack/csharp.svg",
        ETech.Blazor => "imgs/projects/stack/blazor.svg",
        ETech.CSS => "imgs/projects/stack/css3.svg",
        ETech.Dapper => "imgs/projects/stack/dapper.svg",
        ETech.Docker => "imgs/projects/stack/docker.svg",
        ETech.DotNet => "imgs/projects/stack/dotnet.svg",
        ETech.EntityFramework => "imgs/projects/stack/ef.svg",
        ETech.Firebase => "imgs/projects/stack/firebase.svg",
        ETech.HTML => "imgs/projects/stack/html5.svg",
        ETech.JavaScript => "imgs/projects/stack/javascript.svg",
        ETech.Kotlin => "imgs/projects/stack/kotlin.svg",
        ETech.PostgreSQL => "imgs/projects/stack/postgresql.svg",
        ETech.SQL => "imgs/projects/stack/sql.svg",
        ETech.SQLite => "imgs/projects/stack/sqlite.svg",
        ETech.TailwindCSS => "imgs/projects/stack/tailwindcss.svg",
        ETech.VisualBasic => "imgs/projects/stack/vb.svg",

        _ => ""
    };
}