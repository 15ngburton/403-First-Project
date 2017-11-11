# 403-First-Project

Adding this here becuase, for whatever reason, my branch isn't showing up. 



MissionFAQ VIEW:


<nav class="breadcrumb">
    <a class="breadcrumb-item">@Html.ActionLink("England London Mission", "MissionFAQ", "Home", new { mission = "England London Mission" })</a>  /
    <a class="breadcrumb-item" href="#">@Html.ActionLink("Burchev Albania Mission", "MissionFAQ", "Home", new { mission = "Burchev Albania Mission" })</a>  /
    <a class="breadcrumb-item" href="#">@Html.ActionLink("Brasilia Brasil Mission", "MissionFAQ", "Home", new { mission = "Brasilia Brasil Mission" })</a>
</nav>

<p>Mission Name: @ViewBag.missionName</p><br />
       <p>Mission President's Name:@ViewBag.missionPresidentName</p><br />
        <p>Mission Address:@ViewBag.missionAddress</p><br />
        <p>Mission Language: @ViewBag.missionLanguage</p><br />
        <p>Mission Climate: @ViewBag.missionClimate</p><br />
        <p>Dominant Religion: @ViewBag.DominantReligion</p><br />
        <img src="@ViewBag.missionFileName" />
        
        


MissionFAQ METHOD IN THE HOME CONTROLLER:

        public ActionResult MissionFAQ(String mission)
        {   
            switch (mission)
            {
                case "England London Mission":
                    Missions EngLondMission = new Missions("England London Mission",  "Mark Stevenson", "380 S. Piccadily Way, London, UK 483703", "English", "Cold", "Church of England", "");

                    ViewBag.missionName = EngLondMission.missionName;
                    ViewBag.missionPresidentName = EngLondMission.missionPresidentName;
                    ViewBag.missionAddress = EngLondMission.missionAddress;
                    ViewBag.missionClimate = EngLondMission.missionClimate;
                    ViewBag.dominantReligion = EngLondMission.dominantReligion;
                    ViewBag.imageFileName = EngLondMission.imgFileName;

                    break;

                case "Burchev Albania Mission":
                    Missions BurAlbMission = new Missions("Burchev Albania Mission", "Gerald Carol", "P.O. Box 278 37th Steet Post Office, Albania", "Albanian", "Temparate", "Christian Orthodox", "");

                    ViewBag.missionName = BurAlbMission.missionName;
                    ViewBag.missionPresidentName = BurAlbMission.missionPresidentName;
                    ViewBag.missionAddress = BurAlbMission.missionAddress;
                    ViewBag.missionClimate = BurAlbMission.missionClimate;
                    ViewBag.dominantReligion = BurAlbMission.dominantReligion;
                    ViewBag.imageFileName = BurAlbMission.imgFileName;

                    break;

                case "Brasilia Brasil Mission":
                    Missions BrasBrasMission = new Missions("Brasilia Brasil Mission", "Guiermo Fracucci", "3785 Palace Way, Brasilia, Brazil", "Portuguese", "Rainy", "Catholic", "");

                    ViewBag.missionName = BrasBrasMission.missionName;
                    ViewBag.missionPresidentName = BrasBrasMission.missionPresidentName;
                    ViewBag.missionAddress = BrasBrasMission.missionAddress;
                    ViewBag.missionClimate = BrasBrasMission.missionClimate;
                    ViewBag.dominantReligion = BrasBrasMission.dominantReligion;
                    ViewBag.imageFileName = BrasBrasMission.imgFileName;

                    break;
            }



        
        
        
        
ADD THIS CONSTRUCTOR TO THE Missions.cs file:

public Missions(string MissionName, string MissionAddress, string MissionPresidentName, string MissionLanguage, string MissionClimate, string DominantReligion, string ImgFileName)
            {
                this.missionName = MissionName;
                this.missionAddress = MissionAddress;
                this.missionPresidentName = MissionPresidentName;
                this.missionLanguage = MissionLanguage;
                this.missionClimate = MissionClimate;
                this.dominantReligion = DominantReligion;
                this.imgFileName = ImgFileName;
            }
