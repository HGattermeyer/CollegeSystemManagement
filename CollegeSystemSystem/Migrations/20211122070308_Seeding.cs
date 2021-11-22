using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeSystemSystem.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teacher",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Course",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseName" },
                values: new object[,]
                {
                    { 1, "Administration" },
                    { 2, "Mechanical Engineer" },
                    { 3, "Finance" },
                    { 4, "Technology" }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "Id", "BirthDate", "Name", "Wage" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodrigo Marques", 3000.0 },
                    { 2, new DateTime(1984, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beatriz Almeida", 6000.0 },
                    { 3, new DateTime(1990, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomás Gonçalves", 4000.0 },
                    { 4, new DateTime(1989, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Francisco Correia", 3340.0 },
                    { 5, new DateTime(2001, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Catarina Carvalho", 5010.0 },
                    { 6, new DateTime(2004, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana Ferreira", 6800.0 }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2001, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Rolf Ellsworth" },
                    { 2, new DateTime(1970, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Dominique Bunker" },
                    { 3, new DateTime(1956, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Glenda Connealy" },
                    { 4, new DateTime(2003, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pamela Volkert" },
                    { 5, new DateTime(1964, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Michael Goodyear" },
                    { 6, new DateTime(1957, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Mark Latshaw" },
                    { 7, new DateTime(1957, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Ella Watson" },
                    { 8, new DateTime(1957, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Gracie Johnson" },
                    { 9, new DateTime(2003, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Monty Brace" },
                    { 10, new DateTime(1956, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ronald Robinson" },
                    { 11, new DateTime(1991, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Matthew Ruscio" },
                    { 12, new DateTime(1995, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Linda Grove" },
                    { 13, new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Jaimee Barnhart" },
                    { 14, new DateTime(2002, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Michell Crout" },
                    { 15, new DateTime(1986, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Linda Rowe" },
                    { 16, new DateTime(1983, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thomas Dolan" },
                    { 17, new DateTime(1993, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Johanna Sobina" },
                    { 18, new DateTime(1956, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Hazel Obrien" },
                    { 19, new DateTime(1976, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Elicia Weaver" },
                    { 20, new DateTime(1969, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "David Munoz" },
                    { 21, new DateTime(1991, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tara Ebner" },
                    { 22, new DateTime(1969, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lana Lofty" },
                    { 23, new DateTime(1977, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Anna Johnson" },
                    { 24, new DateTime(1974, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Pamela Mitchell" },
                    { 25, new DateTime(1993, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Katrina Curtis" },
                    { 26, new DateTime(1971, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Theodore Fitts" },
                    { 27, new DateTime(1977, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Kristen Cantu" },
                    { 28, new DateTime(2002, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Matthew Welch" },
                    { 29, new DateTime(1988, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Tiffany Phelps" },
                    { 30, new DateTime(1971, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Gloria Hernandez" },
                    { 31, new DateTime(1979, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Paul Dixon" },
                    { 32, new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Jose Jiggetts" },
                    { 33, new DateTime(1983, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "John Conner" },
                    { 34, new DateTime(1966, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Nolan Mixon" },
                    { 35, new DateTime(1953, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Gregg Otto" },
                    { 36, new DateTime(1973, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Anne Mceachern" },
                    { 37, new DateTime(1995, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Jeffrey Steiner" },
                    { 38, new DateTime(1997, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Alice Poulin" },
                    { 39, new DateTime(1969, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Kellie Luttrell" },
                    { 40, new DateTime(1992, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Ethel Riseden" },
                    { 41, new DateTime(1966, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Lily Kiser" },
                    { 42, new DateTime(1950, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cynthia Berry" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "BirthDate", "CourseId", "Name" },
                values: new object[,]
                {
                    { 43, new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Irene Gardner" },
                    { 44, new DateTime(1979, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Fred Caison" },
                    { 45, new DateTime(1977, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Daniel Chin" },
                    { 46, new DateTime(2000, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Rubye Debord" },
                    { 47, new DateTime(1955, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Raymond Becerra" },
                    { 48, new DateTime(1992, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Susan Campos" },
                    { 49, new DateTime(1951, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Kathy Smith" },
                    { 50, new DateTime(1969, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Marylyn Reine" }
                });

            migrationBuilder.InsertData(
                table: "Subject",
                columns: new[] { "Id", "CourseId", "SubjectName", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, "Project Management", 1 },
                    { 2, 1, "Negotiation", 2 },
                    { 3, 1, "International Relashionship", 3 },
                    { 4, 2, "Physics", 4 },
                    { 5, 2, "Vibrations", 5 },
                    { 6, 2, "Rigid Body Mechanics", 6 },
                    { 7, 3, "Taxes", 1 },
                    { 8, 3, "Mutual Funds", 5 },
                    { 9, 3, "Basic Finances", 3 },
                    { 10, 4, "Database Design", 3 },
                    { 11, 4, "Functional Code", 1 },
                    { 12, 4, "JavaScript Code", 6 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "GradeNumber", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1.0, 1, 10 },
                    { 2, 6.0, 1, 11 },
                    { 3, 9.0, 1, 12 },
                    { 4, 5.0, 2, 1 },
                    { 5, 3.0, 2, 2 },
                    { 6, 0.0, 2, 3 },
                    { 7, 9.0, 3, 1 },
                    { 8, 10.0, 3, 2 },
                    { 9, 8.0, 3, 3 },
                    { 10, 7.0, 4, 7 },
                    { 11, 3.0, 4, 8 },
                    { 12, 6.0, 4, 9 },
                    { 13, 1.0, 5, 7 },
                    { 14, 2.0, 5, 8 },
                    { 15, 1.0, 5, 9 },
                    { 16, 4.0, 6, 10 },
                    { 17, 10.0, 6, 11 },
                    { 18, 8.0, 6, 12 },
                    { 19, 2.0, 7, 7 },
                    { 20, 1.0, 7, 8 },
                    { 21, 4.0, 7, 9 },
                    { 22, 4.0, 8, 4 },
                    { 23, 6.0, 8, 5 },
                    { 24, 0.0, 8, 6 },
                    { 25, 8.0, 9, 4 },
                    { 26, 2.0, 9, 5 },
                    { 27, 0.0, 9, 6 },
                    { 28, 9.0, 10, 10 },
                    { 29, 5.0, 10, 11 },
                    { 30, 9.0, 10, 12 },
                    { 31, 0.0, 11, 10 },
                    { 32, 8.0, 11, 11 },
                    { 33, 1.0, 11, 12 },
                    { 34, 4.0, 12, 4 },
                    { 35, 9.0, 12, 5 },
                    { 36, 0.0, 12, 6 },
                    { 37, 3.0, 13, 4 },
                    { 38, 7.0, 13, 5 },
                    { 39, 5.0, 13, 6 },
                    { 40, 5.0, 14, 4 },
                    { 41, 7.0, 14, 5 },
                    { 42, 4.0, 14, 6 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "GradeNumber", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 43, 5.0, 15, 4 },
                    { 44, 1.0, 15, 5 },
                    { 45, 0.0, 15, 6 },
                    { 46, 4.0, 16, 1 },
                    { 47, 1.0, 16, 2 },
                    { 48, 3.0, 16, 3 },
                    { 49, 10.0, 17, 4 },
                    { 50, 9.0, 17, 5 },
                    { 51, 2.0, 17, 6 },
                    { 52, 5.0, 18, 4 },
                    { 53, 10.0, 18, 5 },
                    { 54, 2.0, 18, 6 },
                    { 55, 9.0, 19, 10 },
                    { 56, 10.0, 19, 11 },
                    { 57, 10.0, 19, 12 },
                    { 58, 2.0, 20, 4 },
                    { 59, 1.0, 20, 5 },
                    { 60, 6.0, 20, 6 },
                    { 61, 10.0, 21, 4 },
                    { 62, 4.0, 21, 5 },
                    { 63, 1.0, 21, 6 },
                    { 64, 6.0, 22, 7 },
                    { 65, 9.0, 22, 8 },
                    { 66, 0.0, 22, 9 },
                    { 67, 8.0, 23, 1 },
                    { 68, 6.0, 23, 2 },
                    { 69, 1.0, 23, 3 },
                    { 70, 5.0, 24, 10 },
                    { 71, 0.0, 24, 11 },
                    { 72, 1.0, 24, 12 },
                    { 73, 3.0, 25, 4 },
                    { 74, 6.0, 25, 5 },
                    { 75, 2.0, 25, 6 },
                    { 76, 5.0, 26, 1 },
                    { 77, 10.0, 26, 2 },
                    { 78, 5.0, 26, 3 },
                    { 79, 1.0, 27, 10 },
                    { 80, 2.0, 27, 11 },
                    { 81, 3.0, 27, 12 },
                    { 82, 4.0, 28, 10 },
                    { 83, 10.0, 28, 11 },
                    { 84, 0.0, 28, 12 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "GradeNumber", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 85, 2.0, 29, 10 },
                    { 86, 6.0, 29, 11 },
                    { 87, 0.0, 29, 12 },
                    { 88, 8.0, 30, 10 },
                    { 89, 9.0, 30, 11 },
                    { 90, 5.0, 30, 12 },
                    { 91, 1.0, 31, 4 },
                    { 92, 8.0, 31, 5 },
                    { 93, 5.0, 31, 6 },
                    { 94, 7.0, 32, 10 },
                    { 95, 2.0, 32, 11 },
                    { 96, 1.0, 32, 12 },
                    { 97, 10.0, 33, 1 },
                    { 98, 9.0, 33, 2 },
                    { 99, 8.0, 33, 3 },
                    { 100, 0.0, 34, 10 },
                    { 101, 6.0, 34, 11 },
                    { 102, 4.0, 34, 12 },
                    { 103, 0.0, 35, 10 },
                    { 104, 0.0, 35, 11 },
                    { 105, 2.0, 35, 12 },
                    { 106, 4.0, 36, 10 },
                    { 107, 2.0, 36, 11 },
                    { 108, 6.0, 36, 12 },
                    { 109, 8.0, 37, 7 },
                    { 110, 3.0, 37, 8 },
                    { 111, 3.0, 37, 9 },
                    { 112, 5.0, 38, 4 },
                    { 113, 6.0, 38, 5 },
                    { 114, 8.0, 38, 6 },
                    { 115, 0.0, 39, 1 },
                    { 116, 1.0, 39, 2 },
                    { 117, 6.0, 39, 3 },
                    { 118, 5.0, 40, 10 },
                    { 119, 10.0, 40, 11 },
                    { 120, 8.0, 40, 12 },
                    { 121, 5.0, 41, 4 },
                    { 122, 9.0, 41, 5 },
                    { 123, 1.0, 41, 6 },
                    { 124, 8.0, 42, 4 },
                    { 125, 6.0, 42, 5 },
                    { 126, 3.0, 42, 6 }
                });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "GradeNumber", "StudentId", "SubjectId" },
                values: new object[,]
                {
                    { 127, 7.0, 43, 10 },
                    { 128, 10.0, 43, 11 },
                    { 129, 0.0, 43, 12 },
                    { 130, 6.0, 44, 10 },
                    { 131, 1.0, 44, 11 },
                    { 132, 8.0, 44, 12 },
                    { 133, 8.0, 45, 4 },
                    { 134, 1.0, 45, 5 },
                    { 135, 3.0, 45, 6 },
                    { 136, 0.0, 46, 10 },
                    { 137, 6.0, 46, 11 },
                    { 138, 5.0, 46, 12 },
                    { 139, 7.0, 47, 7 },
                    { 140, 4.0, 47, 8 },
                    { 141, 10.0, 47, 9 },
                    { 142, 3.0, 48, 10 },
                    { 143, 2.0, 48, 11 },
                    { 144, 7.0, 48, 12 },
                    { 145, 9.0, 49, 7 },
                    { 146, 10.0, 49, 8 },
                    { 147, 6.0, 49, 9 },
                    { 148, 10.0, 50, 10 },
                    { 149, 9.0, 50, 11 },
                    { 150, 5.0, 50, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subject",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "CourseName",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }
    }
}
