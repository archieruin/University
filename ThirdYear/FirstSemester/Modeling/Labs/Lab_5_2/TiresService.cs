namespace Lab_5_2
{
    public class TiresService
    {
        public string MakeService()
        {
            string divider = "\n-----------------------------------------------------------------\n";
            string result = "Tires service has been started.";
            result += divider;

            DismantlingTires dismantlingTires = new DismantlingTires();
            MantlingTires mantlingTires = new MantlingTires();
            CleanUpTires cleanUpTires = new CleanUpTires();
            InspectTires inspectTires = new InspectTires();

            result += dismantlingTires.DismantleTires();
            result += divider;

            result += cleanUpTires.CleanUp();
            result += divider;

            result += inspectTires.InspectDisk();
            result += "\n";
            result += inspectTires.InspectCamera();
            result += "\n";
            result += inspectTires.InspectCover();
            result += divider;

            result += mantlingTires.MountTires();
            result += divider;
            return result;
        }
    }

    public class DismantlingTires
    {
        public string DismantleTires()
        {
            return "Tires were removed.";
        }
    }

    public class MantlingTires
    {
        public string MountTires()
        {
            return "Tires were mounted.";
        }
    }

    public class CleanUpTires
    {
        public string CleanUp()
        {
            return "Tires has been cleaned.";
        }
    }

    public class InspectTires
    {
        public string InspectDisk()
        {
            return "Disk is ok.";
        }

        public string InspectCover()
        {
            return "Cover is ok.";
        }

        public string InspectCamera()
        {
            return "Camera is ok.";
        }
    }
}