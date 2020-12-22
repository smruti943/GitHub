# Laboratorium Computer Vision in Microsoft Azure Report

# Computer Vision API:

Computer vision is one of the azure cognitive vision services . This API designed to identify faces and expressions. It is also called as Face API. 
The Face API provides algorithm ,exposed as REST webservice calls to detect , verify , identify and analyse faces. Face API is designed to handle  below tasks:

1.	Verification : Check the likelihood that two faces belong to the same person.
2.	Detection : Detect human faces in an image.
3.	Identification : Search and identify faces.
4.	Similarity : Find similar faces.
5.	Grouping : Organize unidentified faces into groups, based on their visual similarity.

There are three different types of facial data which helps Face API to detect face in images.
Locations: In the image that includes a face, the Face API finds the top, left, width, and height coordinates of the face region. 
It is rectangular pixel area in the image where a face has been identified.
Landmarks: The Face API finds the position of common face elements, such as pupils, nose, and lips. It can return up to 27 landmarks for each identified face, 
that can be used for analysis.
Attributes: The Face API estimates face attributes such as age, gender, hair colour, smile, facial hair, glasses, and emotion.

Face API detects the image and provides data for Face recognition API. Face recognition API  builds recognition patterns from Face detect API. It helps to identify if the same face present in different images .
Storage capacity of Face API:
                            Face list: Up to 1,000 distinct faces
                            Person group: Up to 10,000 persons
                            Person: Up to 248 faces 


Text from Once we recognise face with Face detection API , then comes emotion detection. The Cognitive Services Emotion API builds on these results by using additional methods and algorithms to detect a rich set of emotions in images of human faces. Human face can have various emotions like anger, contempt, disgust, fear, happiness, neutral (the absence of emotion), sadness, and surprise.

Emotion API find these emotions with two parameters namely ,Score and Location.
Score: The likelihood or level of confidence that a face displays a specific emotion
Location: The top, left, height, and width of a region in the image that displays a face
Computer vision service  also able to identify an image or painting .

Use Case:

1.	It should be possible to Identify faces in an image.
2.	System should be able to identify the different type of emotions in a face image like happy, anger , sad etc.
3.	It should be able to identify similar faces.
4.	System should be able to read text from an image.
Face API subscription need to be created before using the service. The subscription created in Azure portal with a resource.

There are two pricing tiers :
1.	Free with 20 calls per minute and 30K calls per month
2.	Standard 10 calls per second. Estimated at 0.84 EUR / 1000 calls

![image](https://user-images.githubusercontent.com/63377540/102924737-70019d00-4492-11eb-870c-9949737960e2.png)


# Custom Vision:

Custom Vision Service is among the newest members of the Cognitive Services suite. Its purpose is to create image classification
models that learns from labelled image user provides. User can upload images and labelled the images appropriately. After labelling
the image, user has to train the model and during training ,it creates iterations and shows the train results.

![image](https://user-images.githubusercontent.com/63377540/102924786-83146d00-4492-11eb-9f33-052b698a4de1.png)

Once training completes, it is possible to test by uploading one of the previously uploaded image . 
System shows the tags on the image and shows the percentage of accuracy. If we test with any other similar image,
custom vision will compare with available images and shows the results.Custom Vision Service portal allows user to create different projects.
The features can be extended to third party with Custom visions API and REST frame work.

There are two pricing tiers :

1.	Free with 20 calls per minute and 5K calls per month
2.	Standard 10 calls per second. Estimated at 0.84 EUR / 1000 calls
Free - Free, allows you to make 2 transactions per second, 2 projects are allowed, 1 hour of network learning per month,
maintaining 5,000 photos to learn and 10,000 transactions per month
Standard - allows 10 transactions per second, price depends on the tasks performed, $ 2 per 1000 transactions,
$ 20 per hour of teaching the network and $ 0.70 per 1000 photos.

# Video Indexer :

Azure Video Indexer is a service to extract insights from media. It uses machine learning models that can be further customized and trained.
The video insights include face identification, text recognition, object labels, scene segmentations, and more. Additional insights are extracted
from audio, such as transcription and emotion detection. You can use these results to improve search, extract clips, create thumbnails, and more.
With Video Indexer it is possible to create different labels  present in the video. It is also possible to access the Video Indexer via API .
Account Id and API Key are require to access API. These values can be collected from Video Indexer Developer portal.

Use Case:

1.	It should be possible to index the labels in the video.
2.	It should be possible to get insights from the video.
3.	It should be possible to identify transcripts from the audio.

Pricing :

Audio, video analysis - $ 0.034 per day
Video encoding - standard $ 0.015, premium $ 0.035
Live processing - $ 0.034 per day
Streaming - standard $ 2.15 per day, up to 600 Mbp, premium $ 4.64 per day, up to 200 Mbps per movie
Content Protection - Depending on the service, $ 0.20 for 100 licenses or $ 0.10 for 100 keys

![image](https://user-images.githubusercontent.com/63377540/102924890-b0611b00-4492-11eb-9aa1-569259d4b780.png)


# Project ShopSystem - Custom Vision

Shop system - assessment of the quality of the freshness of a product - e.g. a banana by its colour.  

We created shop system using Custom Vision , which will identify fresh fruits and rotten fruits. There are three types of fruits namely banana , apple and pear. Images of these fruits are uploaded to Custom Vision. After upload we created different tags for each images. The tags are Fruit ,fresh banana , rotten banana ,fresh apple , rotten apple , fresh pear , rotten pear .  After tagging all images ,we train our model . Once training completed , we tested our model with some images . Custom Vision was able to identify the products with more than 50% accuracy .It is possible to include more product in the system and train it to get better result.  Once the system is published , it is possible to call the system  from other external systems.

Use cases:

1.	System should be able to identify basic fruits like apple , banana and pears etc.
2.	System should be able to distinguish between fresh and rotten banana.
3.	Distinguish between fresh apple and rotten apple.
4.	Distinguish between fresh pear and rotten pear.

Created an external app with azure to call custom vision, which can be accessed in https://shopsystem20201222195322.azurewebsites.net/


![image](https://user-images.githubusercontent.com/63377540/102933445-8c0d3a80-44a2-11eb-9949-6bc3e0953b40.png)
![image](https://user-images.githubusercontent.com/63377540/102933765-2a999b80-44a3-11eb-861c-39a930eff9cf.png)
![image](https://user-images.githubusercontent.com/63377540/102933879-6d5b7380-44a3-11eb-90db-f3a99058a22b.png)
![image](https://user-images.githubusercontent.com/63377540/102934079-c3301b80-44a3-11eb-92d3-045ab13251d8.png)









