# GitHub
In this lab we will create a chatbot for a bank website.The bot will be the first level of contact for any type of information.
Based upon the customer interaction bot will show appropriate informations and when necessary guide the customer.
With the use of bot bank will be able to reduce some pressure from customer support represntatives.
Bot will be helpfull to assign task to correct support persona and strem line routine bank office staff. Also it would be possible to give  24X7 customer support.
Measuring customer satisfication,giving guidance on financial matters,personal marketing startegies etc.

We will create a simple bot with basic feature.Initially there will not be any 3rd party  integration but we will explore more in future.
Our Bot will have only QnA maker and Knowledge base.

Bot service helps customer know about services and products offering from bank .Customer can get information about 

i)How to block a card

ii)Report lost or stolen card

iii)Modify card limit Instruction

iv)Card PIN generation Instruction

v)Information about check in accounts

vi) Information about mortgage loans

vii) Request a call back

Viii) Feedback from Customer

In the first phase we created below three services for our bot:
1.Content Moderator
2.Language Understanding Intelligent Service (LUIS)
3.Text Analytics API


1.Content Moderator

As the name suggest Content moderator help stemline the contents.Azure provides machine assited content
moderation for images,text and video.Bascically the content are dived in to three parts namely
 a.Profanity
 When user types any kind of valugur or swearwords , it identifiies and mark it as Profanity type.
 
 b.Classifcation
 Calsifications are the word or images with adult/sexual contents,which are further divided in to three categories as below:
 
 Category 1: Potential presence of language that might be considered sexually explicit or adult in certain situations.
Category 2: Potential presence of language that might be considered sexually suggestive or mature in certain situations.
Category 3: Potential presence of language that might be considered offensive in certain situations.
 
 c.Personally indetifiable information (PII)
 These are the words related to a persons personal details like address,phone,PESEL number etc.
 Content Moderator mark these items as PII.
 
 Different text can be tested in below content moderator link with valid Subscription key:
 https://westus2.dev.cognitive.microsoft.com/docs/services/57cf753a3f9b070c105bd2c1/operations/57cf753a3f9b070868a1f66f/console
 
 Pricing :
 0-1M transactions - $ 1 per 1,000 transactions

1M-5M transactions - $ 0.75 per 1,000 transactions

5M-10M transactions - $ 0.60 per 1,000 transactions

10M + transactions - $ 0.40 per 1,000 transactions


2. Language Understanding Intelligent Service (LUIS) 
 
 LUIS is an service which adds conversational intelligence to bots.Its possible to create
 different features like intents and utterence in LUIS.With this feature we can train bot with many different Languages.
 
 It use mainly three key aspects of undestanding language:
 Utterances : It is the input from the user,which the bot need to interpret
 Intents:It repesents a action the user want to do.which was expressed in a users utterances.
 Entities: It represents a word or phrase inside the utterance. These are saved as facet.
 
 In LUIS , we have to create different Intents and Entities which will enhance the capability
 of our bot to interact in a better way. Training with many different types will help understand user better.
 The service can be tested in below link with proper key:
 https://www.luis.ai/conversations/applications
 
 Pricings:
Free unlimited transactions,with 10 transactions per second.
Standard -50 per second 
        $ 1.50 for 1000 text messages
        $ 5.50 for 1000 voicemails.
 
 3. Text Analytics API
 
 This is used to find out the sentiment in a sentence or word.It is used in identifying 
 customer sentiments from their feedback on Product or Service.Text Analytics API is a Cognitive Service designed to 
extract infromtaion from text.It use machine learning  algorithm to generate a sentiment score between 0 and 1.
 In Azure we can design a feedback storage and define the type of feedbacks. Its is alos possible to queue the feedback
 in to different types. With use of Sentiment analysis in azure feedback can be dived in to three types:
  Postive feedback: Sentiment score more than 0.5 >= 1
 Negative feedback : If Sentiment score falls between 0 > 0.5
 Netural feedback :  If Sentiment score is 0.5 than its considered as netural feedback
 
 The service can be tested in below link with proper key:
 https://westus2.dev.cognitive.microsoft.com/docs/services/TextAnalytics.V2.0/operations/56f30ceeeda5650db055a3c6/console
 
 Pricing:
 Free:
5,000 transactions per month

Standard:
0-500,000 messages - $ 2 for 1,000 messages

0.5M-2.5M messages - $ 1 for 1,000 messages

2.5M-10.0M messages - $ 0.50 for 1,000 messages

10M + messages - $ 0.25 for 1,000 messages
