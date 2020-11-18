# Process and Translate Speech with Azure Cognitive Speech Services- report 3
# Smruti Sanjeeta Jena

Speech translation is the process in which one spoken phrases is translated in to a different language.It is alos possible to say the translated word in loud.This kind of technology enable speaker of different language communicate with each other. 
Speech translation services are used in many scenarios today.

Live presentation translation
In-person or remote translated communications
Customer support
Business intelligence
Media subtitling
Multilingual AI interactions

Azure Cognitive Services provides a robust machine learning and artificial intelligence-based services for speech translation in real time.

In this service we leared about voice synthesizing. The speech service from Azure has speech sythesis process which use artificail inteligence to translate human voice in to text speech. Text to speech is another tool which produce human like sound from text,which is amazing.With speech service combining we can make a set of vocal tracts or voices to use
during synthesis. Scenarios in which speech synthesis is being adopted include:

1. Improving accessibility

2. Responding in multitasking scenarios

3.Enhancing learning with multiple modes

4.Delivering intuitive bots or assistants

We started with Creating the Speech Service resources on Azure.Speech resource created in Azure with required details.Subscription keys and endpoint were noted.After that we moved to create Synthesize speech to audio output with availabe C# code. We followed the instruction and able to convert audio file to text formart.Later with Synthesize speech to an audio file ,we were able to convert speech text to an audio file.Text-to-speech from the Speech service enables the applications, tools, or devices to convert text into human-like synthesized speech. 

Pricing: F0- Free 
           
         S0 - Standard   
         speech to text  $0.76 per audio hrs
         Test to Speech  $2.982 per 1M text
         
 # BankChatBot -TISA


Created a Bank chat bot named TISA. This bot helps user with basic questions related to their bank account and cards operations.
Details about bank products and services. There are many more possibilities which can be added to this bot. 

For this bot we prepared two types of FAQ’s.
This first FAQ’s is more general and created with basic question and answers related to any bank.
For second FAQ,I took the format from “Citi Handlowy “ . Some of the answers have link to the bank website,which works perfectly. There are other links for bank website which works without any error.


Our bot is created with the help of “Bot Framework Composer” . LUIS and QnA maker are integrated with the bot. Currently bot understand only English language, but it’s possible to create similar bot in other available languages. LUIS help us understand language sentiments.


With QnA maker creating bot is very interesting. It allows to create knowledge base. Where we can upload file for FAQ’s. We choose Professional bot in QnA maker. Also its possible to create customised questions and answers. Even we can make a chain conversation with QnA maker. For specific answers we can create multiple key words and train our knowledge base. Also QnA maker allows to save hyperlinks as answers, which will show as link to user. If user clicks on the link, it will take to respective bank website. This feature in QnA maker makes it easy to integrate with bank website. So there is no additional development needed from bank to be able to implement this bot.  Our bot handles queries, which are not related to bank services as a professional.        
    
Screen shot from Bot Framework Composer

![bankchatbot](https://user-images.githubusercontent.com/63377540/99473157-511b6280-294a-11eb-9afd-947f3d148ef0.PNG)


Screen shot from Bot Framework Emulator

![bot](https://user-images.githubusercontent.com/63377540/99473173-55478000-294a-11eb-8562-11ab974b786d.PNG)


Link to code : https://github.com/smruti943/GitHub/tree/AI-on-Microsoft-Azure-PW/BankChatbot_export
