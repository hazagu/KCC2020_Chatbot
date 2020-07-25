# KCC2020_Chatbot : TEAM23 [챗봇하자구]

###  서비스 명 : MannerBot

#### 누군가에게 묻기 힘들지만 혼자 판단하기 어려운 생활예절을 궁금해 하는 사람들을 위해 도움을 주는 챗봇

corebot, QnA model, LUIS model with Dispatch model

Use the Dispatch model in cases when:

- Your bot consists of multiple language modules (LUIS + QnA) and you need assistance in routing user's utterances to these modules in order to integrate the different modules into your bot.
- Evaluate quality of intents classification of a single LUIS model.
- Create a text classification model from text files.

[MannerBot 만들기](youtube url)


### Overview

This bot uses the Dispatch service to route utterances as it demonstrates the use of multiple LUIS models and QnA maker services to support multiper conversational scenarios.

## Gate01 : Create Echobot & Deploy the bot to Azure

1. echobot 생성
2. 배포하기

## Gate02

1. 챗봇의 주제 정하기
2. QnA model 생성
3. mannerbotwithQnA 생성

## Gate03

1. QnA model 
2. LUIS model

## Gate04

### Step of Create Mannerbot
step 1 : corebot 생성 - visual studio 2019

step 2 : QnA model 생성 - QnA Maker & Azure portal

step 3 : LUIS model 생성

step 4 : dispatch 생성 - cmd

step 5 : code 수정 - visual studio 2019

step 6 : Deploy the bot to Azure - visual studio 2019, Azure portal

### Role

dispatch : LUIS 모델 및 QnA 모델 사용

LUIS : 문장교정

QnA : 생활 예절 질문 및 답변

### Use Dispatch with Multiple LUIS and QnA Models

To learn how to configure Dispatch with multiple LUIS models and QnA Maker services, refer to the steps found [here](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-tutorial-dispatch?view=azure-bot-service-4.0).

## MannerBot url
[]()

## Chatbot 실행하기
### Testing the bot using Bot Framework Emulator

[Bot Framework Emulator](https://github.com/microsoft/botframework-emulator) is a desktop application that allows bot developers to test and debug their bots on localhost or running remotely through a tunnel.

- Install the latest Bot Framework Emulator from [here](https://github.com/Microsoft/BotFramework-Emulator/releases)

### Connect to the bot using Bot Framework Emulator

- Launch Bot Framework Emulator
- File -> Open Bot
- Enter a Bot URL of `http://localhost:3978/api/messages`

## Interacting with the bot

Once you are comfortable with the concepts presented in this sample, you may want to configure Dispatch using a CLI tool.  [Dispatch CLI](https://github.com/Microsoft/botbuilder-tools/tree/master/packages/Dispatch) is a CLI tool that enables you to create a dispatch NLP model across the different LUIS applications and/ or QnA Maker Knowledge Bases you have for your bot.

## Deploy the bot to Azure


## 참고한 문서

- [Bot Framework Documentation](https://docs.botframework.com)
- [Bot Basics](https://docs.microsoft.com/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0)
- [Using LUIS for Language Understanding](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-howto-v4-luis?view=azure-bot-service-4.0&tabs=js)
- [LUIS documentation](https://docs.microsoft.com/en-us/azure/cognitive-services/LUIS/)
- [Azure Bot Service Introduction](https://docs.microsoft.com/azure/bot-service/bot-service-overview-introduction?view=azure-bot-service-4.0)
- [Azure Bot Service Documentation](https://docs.microsoft.com/azure/bot-service/?view=azure-bot-service-4.0)
- [Azure CLI](https://docs.microsoft.com/cli/azure/?view=azure-cli-latest)
- [Azure Portal](https://portal.azure.com)
- [Language Understanding using LUIS](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/)
- [다중 LUIS 및 QnA 모델 사용](https://docs.microsoft.com/ko-kr/azure/bot-service/bot-builder-tutorial-dispatch?view=azure-bot-service-4.0&tabs=cs)
