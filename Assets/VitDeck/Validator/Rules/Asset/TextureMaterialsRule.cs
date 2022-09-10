using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace VitDeck.Validator
{
    /// <summary>
    /// アセット内のテクスチャが指定された圧縮形式になっていることを確認する。
    /// </summary>
    public class TextureImporterFormatRule : BaseRule
    {
        private readonly string platform;
        private readonly IEnumerable<TextureImporterFormat> importerFormats;

        public TextureImporterFormatRule(string name, string platform, IEnumerable<TextureImporterFormat> importerFormats) : base(name)
        {
            this.platform = platform;
            this.importerFormats = importerFormats;
        }

        protected override void Logic(ValidationTarget target)
        {
            var pathPrefix = target.GetBaseFolderPath() + "/";
            var paths = target.GetAllAssetPaths().Where(path => path.StartsWith(pathPrefix)).Distinct();
            foreach (var path in paths)
            {
                LogicForPath(path);
            }
        }

        private void LogicForPath(string path)
        {
            var importer = AssetImporter.GetAtPath(path) as TextureImporter;
            if (importer == null)
            {
                return;
            }

            importer.GetPlatformTextureSettings(platform, out var _, out var textureFormat);
            if (importerFormats.Contains(textureFormat))
            {
                return;
            }

            AddIssue(new Issue(
                AssetDatabase.LoadMainAssetAtPath(path),
                IssueLevel.Error,
                string.Format("テクスチャの{0}プラットフォームの圧縮フォーマットが{1}になっています。", platform, textureFormat),
                string.Format("[{0}] のいずれかを選択してください。", string.Join(", ", importerFormats))));
        }
    }
}
