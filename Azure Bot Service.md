# Create a Bot with the Bot Framework Composer Report 2
# Smruti Sanjeeta Jena

In this lab we  learned about QnA Maker and Azure Bot service.As we are designing chatbot which will act as afirst level of support
for users,it should act as human being.Means the way humans interacts with each other in a conversation. A typicall conversation is the exchange questions follwed by an answer.
In simlar way we have to train our bot to understand questions from Users and serve them with appropriate answers. With Azure QnA maker we will be able to create a knowledge base for our service.We also abled to creat a Bot with Bot Framework Composer

# QnA Maker
QnA Maker service enables to define and publish a knowledge base of questions and answers with support for natural language querying. We define questions and answer for our services. Defining as many questions and answers makes the bot understand better.Once all defined,we have to train the bot and test the knowledge base.After training, one can use the built-in test interface in the QnA Maker portal to test bot's knowledge base by submitting questions and reviewing the answers that are returned.Once we are sure about the training of bot we can publish the knowledge base over its REST interface.

UseCase:
1. Chatbot should will start with a "May I help you" message.
2. Chatbot should first respond to user with Greetings
3. Chatbot should be able to give user different options to choose

Pricing:

Free -   3 managed docuemts per month,3 tansacations per second,100 transactions per minute

Standard - 10$ per month for unlimited managed documents,3 tansacations per second,100 transactions per minute 

# Create a bot
With Azure bot servie we will be able to create a bot and later integrate it to QnA maker. We have to create a resource called "Machine Learning" in azure.
Once "Machine Learning" resource created,we create a compute instance for notebook.After creating the bot its possible to connect it to multiple channels; making it possible for 
users to interact with it through web chat, email, Microsoft Teams, and other common communication media.


# Create a Bot with the Bot Framework Composer
Bot Framework Composer is a visual designer that helps you build sophisticated conversational bots without writing code. This is an open-source tool that presents a visual 
canvas for building bots.In this frame work we can integrate Bot Framework Language Generation (LG) library. The Library contains various templates and message formats,which helps to include variation and dynamic contents.We can manage multiple greetings and manage tempalates for our bot.Below is the example of Dialoge framework:

![image](https://user-images.githubusercontent.com/63377540/98999588-55094800-2538-11eb-8c19-dfb31ddd6483.png)

We  learned how to:

- create a basic bot with the composer
- work with dialogs
- use various cards within your bot
- integrate LUIS


Here is a screen shot from our Simple Weather Bot.

![image](https://user-images.githubusercontent.com/63377540/98999455-1d9a9b80-2538-11eb-84c4-f936283e6bd8.png)


UseCase:
1. Create a basic chatbot Who will greet you with your name,after you enter name.
2. Chatbot should understand specific text and provide user with response.
3. Chatbot should be able to trigger different responses based upon the input text.
4. Chatbot shoul be able to show various cards to the user.
5. Chatbot integrated with LUIS and learn from it.


