using portfolio_v2.Enums;

namespace portfolio_v2.Helpers;

public static class TechMap
{

    public static string Icon(ETech eTech) => eTech switch
    {
        ETech.Access => "Imgs/Projects/stack/access.svg",
        ETech.Azure => "Imgs/Projects/stack/azure.svg",
        ETech.CSharp => "Imgs/Projects/stack/csharp.svg",
        ETech.Blazor => "Imgs/Projects/stack/blazor.svg",
        ETech.CSS => "Imgs/Projects/stack/css3.svg",
        ETech.Dapper => "Imgs/Projects/stack/dapper.svg",
        ETech.Docker => "Imgs/Projects/stack/docker.svg",
        ETech.DotNet => "Imgs/Projects/stack/dotnet.svg",
        ETech.EntityFramework => "Imgs/Projects/stack/ef.svg",
        ETech.Firebase => "Imgs/Projects/stack/firebase.svg",
        ETech.HTML => "Imgs/Projects/stack/html5.svg",
        ETech.JavaScript => "Imgs/Projects/stack/javascript.svg",
        ETech.Kotlin => "Imgs/Projects/stack/kotlin.svg",
        ETech.PostgreSQL => "Imgs/Projects/stack/postgresql.svg",
        ETech.SQL => "Imgs/Projects/stack/sql.svg",
        ETech.SQLite => "Imgs/Projects/stack/sqlite.svg",
        ETech.TailwindCSS => "Imgs/Projects/stack/tailwindcss.svg",
        ETech.VisualBasic => "Imgs/Projects/stack/vb.svg",

        _ => ""
    };
}