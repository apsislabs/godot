namespace GodotTools.IdeConnection
{
    public struct GodotIdeMetadata
    {
        public int Port { get; }
        public string EditorExecutablePath { get; }

        public GodotIdeMetadata(int port, string editorExecutablePath)
        {
            Port = port;
            EditorExecutablePath = editorExecutablePath;
        }

        public static bool operator ==(GodotIdeMetadata a, GodotIdeMetadata b)
        {
            return a.Port == b.Port && a.EditorExecutablePath == b.EditorExecutablePath;
        }

        public static bool operator !=(GodotIdeMetadata a, GodotIdeMetadata b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is GodotIdeMetadata metadata)
                return metadata == this;

            return false;
        }

        public bool Equals(GodotIdeMetadata other)
        {
            return Port == other.Port && EditorExecutablePath == other.EditorExecutablePath;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Port * 397) ^ (EditorExecutablePath != null ? EditorExecutablePath.GetHashCode() : 0);
            }
        }
    }
}
