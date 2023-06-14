using System.IO;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
namespace Src
{
    public static class FileTool
    {
        
        /// <summary>
        /// 加载本地文本文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static async Task<string> LoadAsset(string path)
        {
            var task = await ReadAllBytesAsync(path);
            return System.Text.Encoding.UTF8.GetString(task);
        }

        /// <summary>
        /// 加载本地图片
        /// </summary>
        /// <param name="path"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static async Task<Texture2D> LoadTexture2D(string path,float width, float  height)
        {
            var texture = new Texture2D((int)width, (int)height);
            var task = await ReadAllBytesAsync(path);
            texture.LoadImage(task);
            return texture;
        }

        public static Sprite T2Sprite(Texture2D texture,int width, int  height)
        {
            return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }

        static async UniTask<byte[]> ReadAllBytesAsync(string path)
        {
            using (FileStream sourceStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true))
            {
                var buffer = new byte[sourceStream.Length];
                await sourceStream.ReadAsync(buffer, 0, (int)sourceStream.Length);
                return buffer;
            }
        }

    }
}
