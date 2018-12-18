using System;
using System.IO;

namespace WhileFalse.FMDL
{
    /// <summary>
    /// Container file for a FMDL model
    /// </summary>
    public class FMDLFile
    {
        private const int FileMagic = ('F' << 24) + ('M' << 16) + ('D' << 8) + ('L');
        public const uint LatestFormatVersion = 1;

        /// <summary>
        /// Did this file parse properly?
        /// </summary>
        public bool IsValid { get; }

        #region File Constructors

        /// <summary>
        /// Creates an instance of an existing FMDL file from the given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static FMDLFile FromStream(Stream stream)
        {
            return new FMDLFile(stream);
        }

        /// <summary>
        /// Instantiates a new empty FMDL file.
        /// </summary>
        public FMDLFile()
        {
            IsValid = true;
        }

        #endregion

        private FMDLFile(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);
            var magic = reader.ReadInt32();
            if (magic != FileMagic)
                return;

            var version = reader.ReadUInt32();

            //THIS MUST GO LAST
            IsValid = true;
        }
    }
}
