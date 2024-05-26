# gpt_audio_in_unity
## Use the chatgpt and amazon polly in the Unity
### Import the OpenAI-Unity package and download this project zip file
1. open unity
2. Go to Package Manager
3. Use URL import  https://github.com/srcnalt/OpenAI-Unity.git this package
### Create the openai api key and Amazon api key
1. Go to https://beta.openai.com/account/api-keys and create the api key
2. And go to https://aws.amazon.com amazon website
3. Create aws account and create the api key in `Security credentials`
### Use your api keys in `Assest > Samples > OpenAI Unity > 0.1.15 > ChatGPT > ChatGPT.cs`
1. Find this code and paste your opai api key:
``` c#
 private OpenAIApi openai = new OpenAIApi("your_opai_key");
```
2. Find this code and paset your amazon access key and secreat key:
``` c#
var credentials = new BasicAWSCredentials("access_key", "secreat_key");
```
