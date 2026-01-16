using portfolio_v2.Enums;

namespace portfolio_v2.Helpers;

public static class TechMap
{

    public static string Icon(ETech eTech) => eTech switch
    {
        ETech.Access => "imgs/Projects/stack/access.svg",
        ETech.Azure => "imgs/Projects/stack/azure.svg",
        ETech.CSharp => "imgs/Projects/stack/csharp.svg",
        ETech.Blazor => "imgs/Projects/stack/blazor.svg",
        ETech.CSS => "imgs/Projects/stack/css3.svg",
        ETech.Dapper => "imgs/Projects/stack/dapper.svg",
        ETech.Docker => "imgs/Projects/stack/docker.svg",
        ETech.DotNet => "imgs/Projects/stack/dotnet.svg",
        ETech.EntityFramework => "imgs/Projects/stack/ef.svg",
        ETech.Firebase => "imgs/Projects/stack/firebase.svg",
        ETech.HTML => "imgs/Projects/stack/html5.svg",
        ETech.JavaScript => "imgs/Projects/stack/javascript.svg",
        ETech.Kotlin => "imgs/Projects/stack/kotlin.svg",
        ETech.PostgreSQL => "imgs/Projects/stack/postgresql.svg",
        ETech.SQL => "imgs/Projects/stack/sql.svg",
        ETech.SQLite => "imgs/Projects/stack/sqlite.svg",
        ETech.TailwindCSS => "imgs/Projects/stack/tailwindcss.svg",
        ETech.VisualBasic => "imgs/Projects/stack/vb.svg",

        _ => ""
    };
}