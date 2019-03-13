using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBMS_MiniProject
{
    //Query_Class--------------------------------------------------------------------------
    class Query
    {
        public static string connectionString = "Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static int Execute(string query)
        {
            string conString = Query.connectionString;
            int result = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = query; //"INSERT INTO Clo(Name, DateCreated, DateUpdated) values ('ABC', '2018-10-20', '2018-10-20')";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteNonQuery();
            }
            con.Close();
            return result;
        }
    }
    //Clo_Class----------------------------------------------------------------------
    class Clo
    {
        //Clo_DataMembers-------------------------------------------------------------
        int id;
        string name;
        DateTime dateCreated;
        DateTime dateUpdated;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                dateUpdated = DateTime.Now;
            }
        }

        public DateTime DateUpdated
        {
            get
            {
                return dateUpdated;
            }
            set
            {
                dateUpdated = value;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
            set
            {
                dateCreated = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        //Clo_MemberFunctions-------------------------------------------------------------
        public Clo(string name)
        {
            this.id = -1;
            this.name = name;
            this.dateCreated = DateTime.Now;
            this.dateUpdated = DateTime.Now;
        }
        public static bool deleteCloById(int id)
        {
            if (Query.Execute("DELETE FROM Clo WHERE Id = '" + id + "'") > 0) return true;
            else return false;
        }

        public static Clo getClo(string name)
        {
            string str = name;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Clo clo = new Clo("Empty");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Clo WHERE Name = '" + str + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    clo.id = result.GetInt32(0);
                    clo.name = result.GetString(1);
                    clo.dateCreated = result.GetDateTime(2);
                    clo.dateUpdated = result.GetDateTime(3);
                    break;
                }
            }
            con.Close();
            return clo;
        }

        public static Clo getClobyId(int ID)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Clo clo = new Clo("Empty");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Clo WHERE Id = '" + ID.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    clo.id = result.GetInt32(0);
                    clo.name = result.GetString(1);
                    clo.dateCreated = result.GetDateTime(2);
                    clo.dateUpdated = result.GetDateTime(3);
                    break;
                }
            }
            con.Close();
            return clo;
        }

        public static List<Clo> retrieveClos()
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Clo> cloList = new List<Clo>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Clo";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Clo clo = new Clo(result.GetString(1));
                    clo.id = result.GetInt32(0);
                    clo.dateCreated = result.GetDateTime(2);
                    clo.dateUpdated = result.GetDateTime(3);
                    cloList.Add(clo);
                }
            }
            con.Close();
            return cloList;
        }
        public static int addClo(Clo clo)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            Clo tempClo = new Clo("Empty");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Clo WHERE Id = '" + clo.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempClo.id = result.GetInt32(0);
                    tempClo.name = result.GetString(1);
                    tempClo.dateCreated = result.GetDateTime(2);
                    tempClo.dateUpdated = result.GetDateTime(3);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (tempClo.name != clo.name && !tempClo.name.Equals("Empty"))
                {
                    Query.Execute("UPDATE Clo SET Name = '" + clo.name + "', DateUpdated = '" + clo.dateUpdated.ToString(@"yyyy-MM-dd") + "' WHERE Id = '" + clo.id + "'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM Clo WHERE Name = '" + clo.name + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO Clo(Name, DateCreated, DateUpdated) values ('" + clo.name + "', '" + clo.dateCreated.ToString(@"yyyy-MM-dd") + "', '" + clo.dateUpdated.ToString(@"yyyy-MM-dd") + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
    }
    //Rubric_Class-----------------------------------------------------------------------
    class Rubric
    {
        //Rubric_DataMembers-------------------------------------------------------------
        static int globalNextId;
        int id;
        string details;
        int cloId;


        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Details
        {
            get
            {
                return details;
            }

            set
            {
                details = value;
            }
        }

        public int CloId
        {
            get
            {
                return cloId;
            }
        }
        //Rubric_MemberFunctions----------------------------------------------------
        public static bool updateGlobalId()
        {
            int maxId = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT MAX(Id) FROM Rubric";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    if (!result.IsDBNull(0))
                    {
                        maxId = result.GetInt32(0);
                    }
                    break;
                }
            }
            con.Close();
            if (maxId + 1 == globalNextId)
            {
                return false;
            }
            globalNextId = maxId + 1;
            return true;
        }
        public Rubric(string details, int cloId)
        {
            this.id = -1;
            this.details = details;
            this.cloId = cloId;
        }
        public static Rubric getRubricById(int id)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Rubric rubric = new Rubric("Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Rubric WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    rubric.id = result.GetInt32(0);
                    rubric.details = result.GetString(1);
                    rubric.cloId = result.GetInt32(2);
                    break;
                }
            }
            con.Close();
            return rubric;
        }

        public static Rubric getRubric(string details, int cloId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Rubric rubric = new Rubric("Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Rubric WHERE Details = '" + details + "' AND CloId = '" + cloId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    rubric.id = result.GetInt32(0);
                    rubric.details = result.GetString(1);
                    rubric.cloId = result.GetInt32(2);
                    break;
                }
            }
            con.Close();
            return rubric;
        }
        public static int addRubric(Rubric rubric)
        {
            if (rubric.cloId == -1 || rubric.details == "Empty") return 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            Rubric tempRubric = new Rubric("Empty", -1);
            int status = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Rubric WHERE Id = '" + rubric.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempRubric.id = result.GetInt32(0);
                    tempRubric.details = result.GetString(1);
                    tempRubric.cloId = result.GetInt32(2);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    (!tempRubric.details.Equals("Empty")) &&
                    (
                      (tempRubric.details != rubric.details) ||
                      (tempRubric.cloId != rubric.cloId)
                    )
                  )
                {
                    Query.Execute("UPDATE Rubric SET Details = '" + rubric.details + "', CloId = '" + rubric.cloId + "' WHERE Id = '" + rubric.id + "'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM Rubric WHERE Details = '" + rubric.details + "' AND CloId = '" + rubric.cloId + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Rubric.updateGlobalId();
                    Query.Execute("INSERT INTO Rubric(Id, Details, CloId) VALUES ('" + globalNextId + "', '" + rubric.details + "', '" + rubric.cloId + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }

        public static List<Rubric> retriveRubrics(int cloId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Rubric> rubricList = new List<Rubric>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Rubric WHERE CloId = '" + cloId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Rubric rubric = new Rubric(result.GetString(1), result.GetInt32(2));
                    rubric.id = result.GetInt32(0);
                    rubricList.Add(rubric);
                }
            }
            con.Close();
            return rubricList;
        }
    }
    //RubricLevel_Class-------------------------------------------------------------------
    class RubricLevel
    {
        //RubricLevel_DataMembers----------------------------------------------------
        int id;
        int rubricId;
        string details;
        int measurementLevel;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public int RubricId
        {
            get
            {
                return rubricId;
            }
        }

        public string Details
        {
            get
            {
                return details;
            }

            set
            {
                details = value;
            }
        }

        public int MeasurementLevel
        {
            get
            {
                return measurementLevel;
            }

            set
            {
                measurementLevel = value;
            }
        }
        //RubricLevel_MemberFunctions------------------------------------------------
        public RubricLevel(int rubricId, string details, int measurementLevel)
        {
            this.id = -1;
            this.rubricId = rubricId;
            this.details = details;
            this.measurementLevel = measurementLevel;
        }

        public static RubricLevel getRubricLevel(int rubricId, string details, int measurementLevel)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            RubricLevel rubricLevel = new RubricLevel(-1, "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM RubricLevel WHERE RubricId = '" + rubricId + "' AND Details = '" + details + "' AND MeasurementLevel = '" + measurementLevel + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    rubricLevel.id = result.GetInt32(0);
                    rubricLevel.rubricId = result.GetInt32(1);
                    rubricLevel.details = result.GetString(2);
                    rubricLevel.measurementLevel = result.GetInt32(3);
                    break;
                }
            }
            con.Close();
            return rubricLevel;
        }
        public static RubricLevel getRubricLevelById(int id)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            RubricLevel rubricLevel = new RubricLevel(-1, "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM RubricLevel WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    rubricLevel.id = result.GetInt32(0);
                    rubricLevel.rubricId = result.GetInt32(1);
                    rubricLevel.details = result.GetString(2);
                    rubricLevel.measurementLevel = result.GetInt32(3);
                    break;
                }
            }
            con.Close();
            return rubricLevel;
        }

        public static int addRubricLevel(RubricLevel rubricLevel)
        {
            if (rubricLevel.rubricId == -1 || rubricLevel.details == "Empty") return 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            RubricLevel tempRubricLevel = new RubricLevel(-1, "Empty", -1);
            int status = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM RubricLevel WHERE Id = '" + rubricLevel.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempRubricLevel.id = result.GetInt32(0);
                    tempRubricLevel.rubricId = result.GetInt32(1);
                    tempRubricLevel.details = result.GetString(2);
                    tempRubricLevel.measurementLevel = result.GetInt32(3);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    (!tempRubricLevel.details.Equals("Empty")) &&
                    (
                      (tempRubricLevel.details != rubricLevel.details) ||
                      (tempRubricLevel.rubricId != rubricLevel.rubricId) ||
                      (tempRubricLevel.measurementLevel != rubricLevel.measurementLevel)
                    )
                  )
                {
                    Query.Execute("UPDATE RubricLevel SET RubricId = '" + rubricLevel.rubricId + "', Details = '" + rubricLevel.details + "', MeasurementLevel = '" + rubricLevel.measurementLevel + "' WHERE Id = '" + rubricLevel.id + "'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM RubricLevel WHERE RubricId = '" + rubricLevel.rubricId + "'AND Details = '" + rubricLevel.details + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO RubricLevel(RubricId, Details, MeasurementLevel) VALUES ('" + rubricLevel.rubricId + "', '" + rubricLevel.details + "', '" + rubricLevel.measurementLevel + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
        public static List<RubricLevel> retriveRubricLevels(int rubricId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<RubricLevel> rubricLevelList = new List<RubricLevel>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM RubricLevel WHERE RubricId = '" + rubricId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    RubricLevel rubricLevel = new RubricLevel(result.GetInt32(1), result.GetString(2), result.GetInt32(3));
                    rubricLevel.id = result.GetInt32(0);
                    rubricLevelList.Add(rubricLevel);
                }
            }
            con.Close();
            return rubricLevelList;
        }
    }
    //Assessment_Class-------------------------------------------------------------------
    class Assessment
    {
        //Assessment_DataMembers-------------------------------------------------------------
        int id;
        string title;
        DateTime dateCreated;
        int totalMarks;
        int totalWeightage;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
        }

        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }

            set
            {
                totalMarks = value;
            }
        }

        public int TotalWeightage
        {
            get
            {
                return totalWeightage;
            }

            set
            {
                totalWeightage = value;
            }
        }
        //Assessment_MemberFunctions-------------------------------------------------------------
        public Assessment(string title, int totalMarks, int totalWeightage)
        {
            this.id = -1;
            this.title = title;
            this.dateCreated = DateTime.Now;
            this.totalMarks = totalMarks;
            this.totalWeightage = totalWeightage;
        }
        public static Assessment getAssessment(string title)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Assessment assessment = new Assessment("Empty", -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Assessment WHERE Title = '" + title + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    assessment.id = result.GetInt32(0);
                    assessment.title = result.GetString(1);
                    assessment.dateCreated = result.GetDateTime(2);
                    assessment.totalMarks = result.GetInt32(3);
                    assessment.totalWeightage = result.GetInt32(4);
                    break;
                }
            }
            con.Close();
            return assessment;
        }
        public static Assessment getAssessmentById(int id)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Assessment assessment = new Assessment("Empty", -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Assessment WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    assessment.id = result.GetInt32(0);
                    assessment.title = result.GetString(1);
                    assessment.dateCreated = result.GetDateTime(2);
                    assessment.totalMarks = result.GetInt32(3);
                    assessment.totalWeightage = result.GetInt32(4);
                    break;
                }
            }
            con.Close();
            return assessment;
        }

        public static List<Assessment> retrieveAssessments()
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Assessment> assessmentList = new List<Assessment>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Assessment";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Assessment assessment = new Assessment(result.GetString(1), result.GetInt32(3), result.GetInt32(4));
                    assessment.id = result.GetInt32(0);
                    assessment.dateCreated = result.GetDateTime(2);
                    assessmentList.Add(assessment);
                }
            }
            con.Close();
            return assessmentList;
        }
        public static int addAssessment(Assessment assessment)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            Assessment tempAssessment = new Assessment("Empty", -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Assessment WHERE Id = '" + assessment.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempAssessment.id = result.GetInt32(0);
                    tempAssessment.title = result.GetString(1);
                    tempAssessment.dateCreated = result.GetDateTime(2);
                    tempAssessment.totalMarks = result.GetInt32(3);
                    tempAssessment.totalWeightage = result.GetInt32(4);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    (!tempAssessment.title.Equals("Empty")) &&
                    (
                      (tempAssessment.title != assessment.title) ||
                      (tempAssessment.totalMarks != assessment.totalMarks) ||
                      (tempAssessment.totalWeightage != assessment.totalWeightage)
                    )
                   )
                {
                    Query.Execute("UPDATE Assessment SET Title = '" + assessment.title + "', TotalMarks = '" + assessment.totalMarks + "', TotalWeightage = '" + assessment.totalWeightage + "' WHERE Id = '" + assessment.id + "'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM Assessment WHERE Title = '" + assessment.title + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO Assessment(Title, DateCreated, TotalMarks, TotalWeightage) values ('" + assessment.title + "', '" + assessment.dateCreated + "', '" + assessment.totalMarks + "', '" + assessment.totalWeightage + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
    }
    //AssessmentComponent_Class------------------------------------------------------------
    class AssessmentComponent
    {
        //AssessmentComponent_DataMembers--------------------------------------------------
        int id;
        string name;
        int rubricId;
        int totalMarks;
        DateTime dateCreated;
        DateTime dateUpdated;
        int assessmentId;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                dateUpdated = DateTime.Now;
            }
        }

        public int RubricId
        {
            get
            {
                return rubricId;
            }

            set
            {
                rubricId = value;
                dateUpdated = DateTime.Now;
            }
        }

        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }

            set
            {
                totalMarks = value;
                dateUpdated = DateTime.Now;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return dateCreated;
            }
        }

        public DateTime DateUpdated
        {
            get
            {
                return dateUpdated;
            }
        }

        public int AssessmentId
        {
            get
            {
                return assessmentId;
            }

            set
            {
                assessmentId = value;
                dateUpdated = DateTime.Now;
            }
        }
        //AssessmentComponent_MemberFunctions--------------------------------------------------
        public AssessmentComponent(string name, int rubricId, int totalMarks, int assessmentId)
        {
            this.id = -1;
            this.name = name;
            this.rubricId = rubricId;
            this.totalMarks = totalMarks;
            this.dateCreated = DateTime.Now;
            this.dateUpdated = DateTime.Now;
            this.assessmentId = assessmentId;
        }

        public static AssessmentComponent getAssessmentComponent(string name, int assessmentId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            AssessmentComponent assessmentComponent = new AssessmentComponent("Empty", -1, -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM AssessmentComponent WHERE Name = '" + name + "' AND AssessmentId = '" + assessmentId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    assessmentComponent.id = result.GetInt32(0);
                    assessmentComponent.name = result.GetString(1);
                    assessmentComponent.rubricId = result.GetInt32(2);
                    assessmentComponent.totalMarks = result.GetInt32(3);
                    assessmentComponent.dateCreated = result.GetDateTime(4);
                    assessmentComponent.dateUpdated = result.GetDateTime(5);
                    assessmentComponent.assessmentId = result.GetInt32(6);
                    break;
                }
            }
            con.Close();
            return assessmentComponent;
        }

        public static AssessmentComponent getAssessmentComponentById(int id)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            AssessmentComponent assessmentComponent = new AssessmentComponent("Empty", -1, -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM AssessmentComponent WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    assessmentComponent.id = result.GetInt32(0);
                    assessmentComponent.name = result.GetString(1);
                    assessmentComponent.rubricId = result.GetInt32(2);
                    assessmentComponent.totalMarks = result.GetInt32(3);
                    assessmentComponent.dateCreated = result.GetDateTime(4);
                    assessmentComponent.dateUpdated = result.GetDateTime(5);
                    assessmentComponent.assessmentId = result.GetInt32(6);
                    break;
                }
            }
            con.Close();
            return assessmentComponent;
        }

        public static int addAssessmentComponent(AssessmentComponent assessmentComponent)
        {
            if (assessmentComponent.name == "Empty") return 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            AssessmentComponent tempAssessmentComponent = new AssessmentComponent("Empty", -1, -1, -1);
            int status = 0;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM AssessmentComponent WHERE Id = '" + assessmentComponent.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempAssessmentComponent.id = result.GetInt32(0);
                    tempAssessmentComponent.name = result.GetString(1);
                    tempAssessmentComponent.rubricId = result.GetInt32(2);
                    tempAssessmentComponent.totalMarks = result.GetInt32(3);
                    tempAssessmentComponent.dateCreated = result.GetDateTime(4);
                    tempAssessmentComponent.dateUpdated = result.GetDateTime(5);
                    tempAssessmentComponent.assessmentId = result.GetInt32(6);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    (!tempAssessmentComponent.name.Equals("Empty")) &&
                    (
                      (tempAssessmentComponent.name != assessmentComponent.name) ||
                      (tempAssessmentComponent.rubricId != assessmentComponent.rubricId) ||
                      (tempAssessmentComponent.totalMarks != assessmentComponent.totalMarks) ||
                      (tempAssessmentComponent.assessmentId != assessmentComponent.assessmentId)
                    )
                  )
                {
                    Query.Execute("UPDATE AssessmentComponent SET Name = '" + assessmentComponent.name + "', RubricId = '" + assessmentComponent.rubricId + "', TotalMarks = '" + assessmentComponent.totalMarks + "', AssessmentId = '" + assessmentComponent.assessmentId + "' WHERE Id = '" + assessmentComponent.id + "'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM AssessmentComponent WHERE Name = '" + assessmentComponent.name + "'AND RubricId = '" + assessmentComponent.rubricId + "'AND AssessmentId = '" + assessmentComponent.assessmentId + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO AssessmentComponent(Name, RubricId, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES ('" + assessmentComponent.name + "', '" + assessmentComponent.rubricId + "', '" + assessmentComponent.totalMarks + "', '" + assessmentComponent.DateCreated + "', '" + assessmentComponent.dateUpdated + "', '" + assessmentComponent.assessmentId + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
        public static List<AssessmentComponent> retriveAssessmentComponents(int assessmentId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<AssessmentComponent> assessmentComponentList = new List<AssessmentComponent>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM AssessmentComponent WHERE AssessmentId = '" + assessmentId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    AssessmentComponent assessmentComponent = new AssessmentComponent(result.GetString(1), result.GetInt32(2), result.GetInt32(3), result.GetInt32(6));
                    assessmentComponent.id = result.GetInt32(0);
                    assessmentComponent.dateCreated = result.GetDateTime(4);
                    assessmentComponent.dateUpdated = result.GetDateTime(5);
                    assessmentComponentList.Add(assessmentComponent);
                }
            }
            con.Close();
            return assessmentComponentList;
        }
    }
    //ClassAttendance_Class------------------------------------------------------------
    class ClassAttendance
    {
        //ClassAttendance_DataMembers--------------------------------------------------
        int id;
        DateTime attendanceDate;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public DateTime AttendanceDate
        {
            get
            {
                return attendanceDate;
            }

            set
            {
                attendanceDate = value;
            }
        }
        //ClassAttendance_MemberFunctions----------------------------------------------------
        public ClassAttendance()
        {
            this.id = -1;
            this.attendanceDate = DateTime.Now;
        }

        public static ClassAttendance getClassAttendanceById(int id)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            ClassAttendance classAttendance = new ClassAttendance();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM ClassAttendance WHERE Id = '" + id.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    classAttendance.id = result.GetInt32(0);
                    classAttendance.attendanceDate = result.GetDateTime(1);
                    break;
                }
            }
            con.Close();
            return classAttendance;
        }

        public static List<ClassAttendance> retrieveClassAttendance()
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<ClassAttendance> classAttendanceList = new List<ClassAttendance>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM ClassAttendance";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    ClassAttendance classAttendance = new ClassAttendance();
                    classAttendance.id = result.GetInt32(0);
                    classAttendance.attendanceDate = result.GetDateTime(1);
                    classAttendanceList.Add(classAttendance);
                }
            }
            con.Close();
            return classAttendanceList;
        }
        public static int addClassAttendance(ClassAttendance classAttendance)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            ClassAttendance tempClassAttendance = new ClassAttendance();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM ClassAttendance WHERE Id = '" + classAttendance.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempClassAttendance.id = result.GetInt32(0);
                    tempClassAttendance.attendanceDate = result.GetDateTime(1);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    tempClassAttendance.attendanceDate.Year != classAttendance.attendanceDate.Year ||
                    tempClassAttendance.attendanceDate.Month != classAttendance.attendanceDate.Month ||
                    tempClassAttendance.attendanceDate.Day != classAttendance.attendanceDate.Day
                    )
                {
                    Query.Execute("UPDATE ClassAttendance SET AttendanceDate = '" + classAttendance.attendanceDate + "' WHERE Id = '"+classAttendance.id+"'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM ClassAttendance WHERE YEAR(AttendanceDate) = '" + classAttendance.attendanceDate.Year + "'AND MONTH(AttendanceDate) = '" + classAttendance.attendanceDate.Month + "'AND DAY(AttendanceDate) = '" + classAttendance.attendanceDate.Day + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO ClassAttendance(AttendanceDate) values ('" + classAttendance.attendanceDate + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }

    }
    //Lookup_Class----------------------------------------------------------------------
    class Lookup
    {
        //Lookup_DataMembers-------------------------------------------------------------
        int lookupId;
        string name;
        string category;

        public int LookupId
        {
            get
            {
                return lookupId;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        //Lookup_MemberFunctions-------------------------------------------------------------
        public Lookup(string name, string category)
        {
            this.lookupId = -1;
            this.name = name;
            this.category = category;
        }

        public static Lookup getLookup(string name, string category)
        {
            string str = name;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Lookup lookup = new Lookup("Empty", "Empty");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Lookup WHERE Name = '" + name + "' AND Category = '" + category + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    lookup.lookupId = result.GetInt32(0);
                    lookup.name = result.GetString(1);
                    lookup.category = result.GetString(2);
                    break;
                }
            }
            con.Close();
            return lookup;
        }

        public static Lookup getLookupById(int lookupId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Lookup lookup = new Lookup("Empty", "Empty");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Lookup WHERE LookupId = '" + lookupId.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    lookup.lookupId = result.GetInt32(0);
                    lookup.name = result.GetString(1);
                    lookup.category = result.GetString(2);
                    break;
                }
            }
            con.Close();
            return lookup;
        }

        public static List<Lookup> retrieveLookups()
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Lookup> lookupList = new List<Lookup>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Lookup";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Lookup lookup = new Lookup(result.GetString(1), result.GetString(2));
                    lookup.lookupId = result.GetInt32(0);

                    lookupList.Add(lookup);
                }
            }
            con.Close();
            return lookupList;
        }

        public static List<Lookup> retrieveLookupsByName(string name)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Lookup> lookupList = new List<Lookup>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Lookup WHERE Name = '" + name + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Lookup lookup = new Lookup(result.GetString(1), result.GetString(2));
                    lookup.lookupId = result.GetInt32(0);

                    lookupList.Add(lookup);
                }
            }
            con.Close();
            return lookupList;
        }
        public static List<Lookup> retrieveLookupsByCategory(string category)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Lookup> lookupList = new List<Lookup>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Lookup WHERE Category = '" + category + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Lookup lookup = new Lookup(result.GetString(1), result.GetString(2));
                    lookup.lookupId = result.GetInt32(0);

                    lookupList.Add(lookup);
                }
            }
            con.Close();
            return lookupList;
        }

        public static int addLookup(Lookup lookup)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            Lookup tempLookup = new Lookup("Empty", "Empty");
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Lookup WHERE LookupId = '" + lookup.lookupId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempLookup.lookupId = result.GetInt32(0);
                    tempLookup.name = result.GetString(1);
                    tempLookup.category = result.GetString(2);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    (!tempLookup.Name.Equals("Empty") && !tempLookup.category.Equals("Empty")) &&
                    (
                      (!tempLookup.name.Equals(lookup.name)) ||
                      (!tempLookup.category.Equals(lookup.category))
                    )
                   )
                {
                    Query.Execute("UPDATE Lookup SET Name = '" + lookup.name + "', Category = '" + lookup.category + "' WHERE LookupId = '"+lookup.lookupId+"'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM Lookup WHERE Name = '" + lookup.name + "' AND Category = '" + lookup.category + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO Lookup(Name, Category) values ('" + lookup.name + "', '" + lookup.category + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
    }
    //Student_Class----------------------------------------------------------------------
    class Student
    {
        //Student_DataMembers-------------------------------------------------------------
        int id;
        string firstName;
        string lastName;
        string contact;
        string email;
        string registrationNumber;
        int status;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        //Student_MemberFunctions-------------------------------------------------------------
        public Student(string firstName, string lastName, string contact, string email, string registrationNumber, int status)
        {
            this.id = -1;
            this.firstName = firstName;
            this.lastName = lastName;
            this.contact = contact;
            this.email = email;
            this.registrationNumber = registrationNumber;
            this.status = status;
        }
        public static bool deleteStudentById(int id)
        {
            if (Query.Execute("DELETE FROM Student WHERE Id = '" + id + "'") > 0) return true;
            else return false;
        }
        public static Student getStudentByContact(string contact)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Student student = new Student("Empty", "Empty", "Empty", "Empty", "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student WHERE Contact = '" + contact + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    student.id = result.GetInt32(0);
                    student.firstName = result.GetString(1);
                    student.lastName = result.GetString(2);
                    student.contact = result.GetString(3);
                    student.email = result.GetString(4);
                    student.registrationNumber = result.GetString(5);
                    student.status = result.GetInt32(6);

                    break;
                }
            }
            con.Close();
            return student;
        }
        public static Student getStudentByEmail(string email)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Student student = new Student("Empty", "Empty", "Empty", "Empty", "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student WHERE Email = '" + email + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    student.id = result.GetInt32(0);
                    student.firstName = result.GetString(1);
                    student.lastName = result.GetString(2);
                    student.contact = result.GetString(3);
                    student.email = result.GetString(4);
                    student.registrationNumber = result.GetString(5);
                    student.status = result.GetInt32(6);

                    break;
                }
            }
            con.Close();
            return student;
        }

        public static Student getStudentByRegistrationNumber(string registrationNumber)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Student student = new Student("Empty", "Empty", "Empty", "Empty", "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student WHERE RegistrationNumber = '" + registrationNumber + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    student.id = result.GetInt32(0);
                    student.firstName = result.GetString(1);
                    student.lastName = result.GetString(2);
                    student.contact = result.GetString(3);
                    student.email = result.GetString(4);
                    student.registrationNumber = result.GetString(5);
                    student.status = result.GetInt32(6);

                    break;
                }
            }
            con.Close();
            return student;
        }
        public static Student getStudentById(int id)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            Student student = new Student("Empty", "Empty", "Empty", "Empty", "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student WHERE Id = '" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    student.id = result.GetInt32(0);
                    student.firstName = result.GetString(1);
                    student.lastName = result.GetString(2);
                    student.contact = result.GetString(3);
                    student.email = result.GetString(4);
                    student.registrationNumber = result.GetString(5);
                    student.status = result.GetInt32(6);

                    break;
                }
            }
            con.Close();
            return student;
        }
        public static List<Student> retrieveStudents()
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Student> studentList = new List<Student>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Student student = new Student(result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetInt32(6));
                    student.id = result.GetInt32(0);

                    studentList.Add(student);
                }
            }
            con.Close();
            return studentList;
        }
        public static List<Student> retrieveStudentsByStatus(int status)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<Student> studentList = new List<Student>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student WHERE Status = '" + status + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Student student = new Student(result.GetString(1), result.GetString(2), result.GetString(3), result.GetString(4), result.GetString(5), result.GetInt32(6));
                    student.id = result.GetInt32(0);

                    studentList.Add(student);
                }
            }
            con.Close();
            return studentList;
        }

        public static int addStudent(Student student)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            Student tempStudent = new Student("Empty", "Empty", "Empty", "Empty", "Empty", -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM Student WHERE Id = '" + student.id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempStudent.id = result.GetInt32(0);
                    tempStudent.firstName = result.GetString(1);
                    tempStudent.lastName = result.GetString(2);
                    tempStudent.contact = result.GetString(3);
                    tempStudent.email = result.GetString(4);
                    tempStudent.registrationNumber = result.GetString(5);
                    tempStudent.status = result.GetInt32(6);

                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    (!tempStudent.firstName.Equals("Empty") && !tempStudent.lastName.Equals("Empty") && !tempStudent.contact.Equals("Empty") && !tempStudent.email.Equals("Empty") && !tempStudent.registrationNumber.Equals("Empty") && !(tempStudent.status == -1)) &&
                    (
                      (!tempStudent.firstName.Equals(student.firstName)) ||
                      (!tempStudent.lastName.Equals(student.lastName)) ||
                      (!tempStudent.contact.Equals(student.contact)) ||
                      (!tempStudent.email.Equals(student.email)) ||
                      (!tempStudent.registrationNumber.Equals(student.registrationNumber)) ||
                      (!(tempStudent.status == student.status))
                    )
                   )
                {
                    Query.Execute("UPDATE Student SET FirstName = '" + student.firstName + "', LastName = '" + student.lastName + "', Contact = '" + student.contact + "', Email = '" + student.email + "', RegistrationNumber = '" + student.registrationNumber + "', Status = '" + student.status + "' WHERE Id = '"+student.id+"'");
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    //string q = "SELECT * FROM Student WHERE FirstName = '" + student.firstName + "' AND  LastName = '" + student.lastName + "' AND Contact = '" + student.contact + "' AND Email = '" + student.email + "' AND RegistrationNumber = '" + student.registrationNumber + "' AND Status = '" + student.status + "'";
                    string q = "SELECT * FROM Student WHERE Contact = '" + student.contact + "' OR Email = '" + student.email + "' OR RegistrationNumber = '" + student.registrationNumber + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) values ('" + student.firstName + "', '" + student.lastName + "', '" + student.contact + "', '" + student.email + "', '" + student.registrationNumber + "', '" + student.status + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
    }
    //StudentAttendance_Class----------------------------------------------------------------------
    class StudentAttendance
    {
        //StudentAttendance_DataMembers-------------------------------------------------------------
        int attendanceId;
        int studentId;
        int attendanceStatus;

        public int AttendanceId
        {
            get
            {
                return attendanceId;
            }

            set
            {
                attendanceId = value;
            }
        }

        public int StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public int AttendanceStatus
        {
            get
            {
                return attendanceStatus;
            }

            set
            {
                attendanceStatus = value;
            }
        }
        //StudentAttendance_MemberFunctions-------------------------------------------------------------
        public StudentAttendance(int attendanceId, int studentId, int attendanceStatus)
        {
            this.AttendanceId = attendanceId;
            this.StudentId = studentId;
            this.AttendanceStatus = attendanceStatus;
        }

        public static StudentAttendance getStudentAttendance(int attendanceId, int studentId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            StudentAttendance studentAttendance = new StudentAttendance(-1, -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentAttendance WHERE AttendanceId = '" + attendanceId + "' AND StudentId = '" + studentId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    studentAttendance.attendanceId = result.GetInt32(0);
                    studentAttendance.studentId = result.GetInt32(1);
                    studentAttendance.attendanceStatus = result.GetInt32(2);

                    break;
                }
            }
            con.Close();
            return studentAttendance;
        }
        public static List<StudentAttendance> retrieveStudentAttendancesByStudentId(int studentId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<StudentAttendance> studentAttendanceList = new List<StudentAttendance>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentAttendance WHERE StudentId = '"+studentId+"'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    StudentAttendance studentAttendance = new StudentAttendance(result.GetInt32(0), result.GetInt32(1), result.GetInt32(2));
                    
                    studentAttendanceList.Add(studentAttendance);
                }
            }
            con.Close();
            return studentAttendanceList;
        }
        public static List<StudentAttendance> retrieveStudentAttendancesByAttendanceId(int attendanceId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<StudentAttendance> studentAttendanceList = new List<StudentAttendance>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentAttendance WHERE AttendanceId = '" + attendanceId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    StudentAttendance studentAttendance = new StudentAttendance(result.GetInt32(0), result.GetInt32(1), result.GetInt32(2));

                    studentAttendanceList.Add(studentAttendance);
                }
            }
            con.Close();
            return studentAttendanceList;
        }
        
        public static int addStudentAttendance(StudentAttendance studentAttendance, StudentAttendance updatedStudentAttendance)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            StudentAttendance tempStudentAttendance = new StudentAttendance(-1, -1, -1);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentAttendance WHERE AttendanceId = '" + studentAttendance.attendanceId + "' AND StudentId = '"+studentAttendance.studentId+"'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempStudentAttendance.attendanceId = result.GetInt32(0);
                    tempStudentAttendance.studentId = result.GetInt32(1);
                    tempStudentAttendance.attendanceStatus = result.GetInt32(2);
                    
                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    ((tempStudentAttendance.attendanceId != -1) && (tempStudentAttendance.studentId != -1) && (tempStudentAttendance.attendanceStatus != -1)) &&
                    (
                      (studentAttendance.attendanceId != updatedStudentAttendance.attendanceId) ||
                      (studentAttendance.studentId != updatedStudentAttendance.studentId) ||
                      (studentAttendance.attendanceStatus!= updatedStudentAttendance.attendanceStatus)
                    )
                   )
                {
                    if (
                        (studentAttendance.studentId == updatedStudentAttendance.studentId) &&
                        (studentAttendance.attendanceId == updatedStudentAttendance.attendanceId)
                       )
                    {
                        Query.Execute("UPDATE StudentAttendance SET AttendanceStatus = '" + updatedStudentAttendance.attendanceStatus + "' WHERE StudentId = '" + studentAttendance.studentId + "' AND AttendanceId = '" + studentAttendance.attendanceId + "'");
                    }
                    else if (
                        (studentAttendance.attendanceId == updatedStudentAttendance.attendanceId) &&
                        (studentAttendance.attendanceStatus == updatedStudentAttendance.attendanceStatus)
                       )
                    {
                        Query.Execute("UPDATE StudentAttendance SET StudentId = '" + updatedStudentAttendance.studentId + "' WHERE AttendanceId = '" + studentAttendance.attendanceId + "' AND AttendanceStatus = '" + studentAttendance.attendanceStatus + "'");
                    }
                    else if (
                        (studentAttendance.studentId == updatedStudentAttendance.studentId) &&
                        (studentAttendance.attendanceStatus == updatedStudentAttendance.attendanceStatus)
                       )
                    {
                        Query.Execute("UPDATE StudentAttendance SET AttendanceId = '" + updatedStudentAttendance.attendanceId + "' WHERE StudentId = '" + studentAttendance.studentId + "' AND AttendanceStatus = '" + studentAttendance.attendanceStatus + "'");
                    }

                    status = 2;
                }
                
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM StudentAttendance WHERE AttendanceId = '" + studentAttendance.attendanceId + "' AND  StudentId = '" + studentAttendance.studentId +"'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO StudentAttendance(AttendanceId, StudentId, AttendanceStatus) values ('" + studentAttendance.attendanceId + "', '" + studentAttendance.StudentId + "', '" + studentAttendance.attendanceStatus + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
    }
    //StudentResult_Class----------------------------------------------------------------------
    class StudentResult
    {
        //StudentResult_DataMembers-------------------------------------------------------------
        int studentId;
        int assessmentComponentId;
        int rubricMeasurementId;
        DateTime evaluationDate;

        public int StudentId
        {
            get
            {
                return studentId;
            }

            set
            {
                studentId = value;
            }
        }

        public int AssessmentComponentId
        {
            get
            {
                return assessmentComponentId;
            }

            set
            {
                assessmentComponentId = value;
            }
        }

        public int RubricMeasurementId
        {
            get
            {
                return rubricMeasurementId;
            }

            set
            {
                rubricMeasurementId = value;
            }
        }

        public DateTime EvaluationDate
        {
            get
            {
                return evaluationDate;
            }

            set
            {
                evaluationDate = value;
            }
        }

        //StudentAttendance_MemberFunctions-------------------------------------------------------------
        public StudentResult(int studentId, int assessmentComponentId, int rubricMeasurementId, DateTime evaluationDate)
        {
            this.studentId = studentId;
            this.assessmentComponentId = assessmentComponentId;
            this.rubricMeasurementId = rubricMeasurementId;
            this.evaluationDate = evaluationDate;
        }

        public static StudentResult getStudentResult(int studentId, int assessmentComponentId, int rubricMeasurementId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            StudentResult studentResult = new StudentResult(-1, -1, -1, DateTime.Now);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentResult WHERE StudentId = '" + studentId + "' AND AssessmentComponentId = '" + assessmentComponentId + "' AND RubricMeasurementId = '" + rubricMeasurementId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    studentResult.studentId = result.GetInt32(0);
                    studentResult.assessmentComponentId = result.GetInt32(1);
                    studentResult.rubricMeasurementId = result.GetInt32(2);
                    studentResult.evaluationDate = result.GetDateTime(3);

                    break;
                }
            }
            con.Close();
            return studentResult;
        }

        public static List<StudentResult> retrieveStudentResultByStudentId(int studentId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<StudentResult> studentResultList = new List<StudentResult>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentResult WHERE StudentId = '" + studentId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    StudentResult studentResult = new StudentResult(result.GetInt32(0), result.GetInt32(1), result.GetInt32(2), result.GetDateTime(3));

                    studentResultList.Add(studentResult);
                }
            }
            con.Close();
            return studentResultList;
        }
        public static List<StudentResult> retrieveStudentResultByAssessmentComponentId(int assessmentComponentId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<StudentResult> studentResultList = new List<StudentResult>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentResult WHERE AssessmentComponentId = '" + assessmentComponentId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    StudentResult studentResult = new StudentResult(result.GetInt32(0), result.GetInt32(1), result.GetInt32(2), result.GetDateTime(3));

                    studentResultList.Add(studentResult);
                }
            }
            con.Close();
            return studentResultList;
        }
        public static List<StudentResult> retrieveStudentResultByRubricMeasurementId(int rubricMeasurementId)
        {
            string conString = Query.connectionString;
            SqlDataReader result = null;
            List<StudentResult> studentResultList = new List<StudentResult>();
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentResult WHERE RubricMeasurementId = '" + rubricMeasurementId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    StudentResult studentResult = new StudentResult(result.GetInt32(0), result.GetInt32(1), result.GetInt32(2), result.GetDateTime(3));

                    studentResultList.Add(studentResult);
                }
            }
            con.Close();
            return studentResultList;
        }
     public static int addStudentResult(StudentResult studentResult, StudentResult updatedStudentResult)
        {
            int status = 0;
            string conString = Query.connectionString;
            SqlDataReader result = null;
            bool found = false;
            StudentResult tempStudentResult = new StudentResult(-1, -1, -1, DateTime.Now);
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "SELECT * FROM StudentResult WHERE StudentId = '" + studentResult.studentId + "' AND AssessmentComponentId = '" + studentResult.assessmentComponentId + "'AND RubricMeasurementId = '" + studentResult.rubricMeasurementId + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                result = cmd.ExecuteReader();
                while (result.Read())
                {
                    tempStudentResult.studentId = result.GetInt32(0);
                    tempStudentResult.assessmentComponentId = result.GetInt32(1);
                    tempStudentResult.rubricMeasurementId = result.GetInt32(2);
                    tempStudentResult.evaluationDate = result.GetDateTime(3);
                    
                    found = true;
                    break;
                }
                result.Close();
            }
            if (found)
            {
                if (
                    ((tempStudentResult.studentId != -1) && (tempStudentResult.assessmentComponentId != -1) && (tempStudentResult.rubricMeasurementId != -1)) &&
                    (
                      (tempStudentResult.studentId != updatedStudentResult.studentId) ||
                      (tempStudentResult.assessmentComponentId != updatedStudentResult.assessmentComponentId) ||
                      (tempStudentResult.rubricMeasurementId != updatedStudentResult.rubricMeasurementId) ||
                      (tempStudentResult.EvaluationDate.Date != updatedStudentResult.EvaluationDate.Date)
                      
                    )
                   )
                {
                    if (
                        (studentResult.studentId == updatedStudentResult.studentId) &&
                        (studentResult.assessmentComponentId == updatedStudentResult.assessmentComponentId) &&
                        (studentResult.rubricMeasurementId == updatedStudentResult.rubricMeasurementId)
                        )
                    {
                        Query.Execute("UPDATE StudentResult SET EvaluationDate = '" + updatedStudentResult.evaluationDate + "' WHERE StudentId = '" + studentResult.studentId + "' AND AssessmentComponentId = '" + studentResult.assessmentComponentId + "' AND RubricMeasurementId = '" + studentResult.rubricMeasurementId + "'");
                    }
                    else if (
                        (studentResult.studentId == updatedStudentResult.studentId) &&
                        (studentResult.assessmentComponentId == updatedStudentResult.assessmentComponentId) &&
                        (studentResult.EvaluationDate.Date == updatedStudentResult.evaluationDate.Date)
                        )
                    {
                        Query.Execute("UPDATE StudentResult SET RubricMeasurementId = '" + updatedStudentResult.rubricMeasurementId + "' WHERE StudentId = '" + studentResult.studentId + "' AND AssessmentComponentId = '" + studentResult.assessmentComponentId + "' AND YEAR(EvaluationDate) = '" + studentResult.evaluationDate.Year + "' AND Month(EvaluationDate) = '" + studentResult.evaluationDate.Month + "' AND DAY(EvaluationDate) = '" + studentResult.evaluationDate.Day + "'");
                    }
                    else if (
                        (studentResult.studentId == updatedStudentResult.studentId) &&
                        (studentResult.rubricMeasurementId == updatedStudentResult.rubricMeasurementId) &&
                        (studentResult.EvaluationDate.Date == updatedStudentResult.evaluationDate.Date)
                        )
                    {
                        Query.Execute("UPDATE StudentResult SET AssessmentComponentId = '" + updatedStudentResult.assessmentComponentId + "' WHERE StudentId = '" + studentResult.studentId + "' AND RubricMeasurementId = '" + studentResult.rubricMeasurementId + "' AND YEAR(EvaluationDate) = '" + studentResult.evaluationDate.Year + "' AND Month(EvaluationDate) = '" + studentResult.evaluationDate.Month + "' AND DAY(EvaluationDate) = '" + studentResult.evaluationDate.Day + "'");
                    }
                    else if (
                        (studentResult.assessmentComponentId == updatedStudentResult.assessmentComponentId) &&
                        (studentResult.rubricMeasurementId == updatedStudentResult.rubricMeasurementId) &&
                        (studentResult.EvaluationDate.Date == updatedStudentResult.evaluationDate.Date)
                        )
                    {
                        Query.Execute("UPDATE StudentResult SET StudentId = '" + updatedStudentResult.studentId + "' WHERE AssessmentComponentId = '" + studentResult.assessmentComponentId + "' AND RubricMeasurementId = '" + studentResult.rubricMeasurementId + "' AND YEAR(EvaluationDate) = '" + studentResult.evaluationDate.Year + "' AND Month(EvaluationDate) = '" + studentResult.evaluationDate.Month + "' AND DAY(EvaluationDate) = '" + studentResult.evaluationDate.Day + "'");
                    }
                    status = 2;
                }
            }
            else
            {
                bool shouldAdd = true;
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "SELECT * FROM StudentResult WHERE StudentId = '" + studentResult.studentId + "' AND  AssessmentComponentId = '" + studentResult.assessmentComponentId + "' AND RubricMeasurementId = '" + studentResult.rubricMeasurementId + "'";
                    SqlCommand cmd = new SqlCommand(q, con);
                    result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        shouldAdd = false;
                        break;
                    }
                    result.Close();
                }
                if (shouldAdd)
                {
                    Query.Execute("INSERT INTO StudentResult(StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) values ('" + studentResult.studentId + "', '" + studentResult.assessmentComponentId + "', '" + studentResult.rubricMeasurementId + "', '"+ studentResult.evaluationDate.ToString(@"yyyy-MM-dd") + "')");
                    status = 1;
                }
            }
            con.Close();
            return status;
        }
    }
}
