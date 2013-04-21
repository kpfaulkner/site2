using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace site2
{
    class DataManager
    {
        Windows.Storage.ApplicationDataContainer localSettings;
        StorageFolder localFolder;
        
        public DataManager()
        {
            localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        }

        public async void WriteData( List<WordEntry> wordList)
        {
            StorageFile dataFile = await localFolder.CreateFileAsync("wordfile.txt",CreationCollisionOption.ReplaceExisting);

            var json = JsonHelper.SerializeObjectToJson<List<WordEntry>>(wordList);

            await FileIO.WriteTextAsync(dataFile, json);

        }

        async void ReadData()
        {
            try
            {
                StorageFile dataFile = await localFolder.GetFileAsync("wordfile.txt");
                String json = await FileIO.ReadTextAsync(dataFile);

                var wordList = JsonHelper.DeserializeJsonToObject<List<WordEntry>>(json);
                //return wordList;
            }
            catch (Exception)
            {
                // Timestamp not found
            }
        }

    }
}
