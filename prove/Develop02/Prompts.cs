using System;

class Prompts
{
    // entirely from ChatGPT
    private readonly List<string> promptsList = [
        "What was the best part of your day today?",
        "Did anything happen today that made you feel uncomfortable? Describe what occurred and your feelings.",
        "What’s something new you learned today?",
        "List three things you are grateful for right now.",
        "How did you help someone else today, and how did it make you feel?",
        "How are you really feeling today? Describe your emotions as detailed as possible.",
        "What’s been worrying you lately, and what can you do about it?",
        "Reflect on a recent situation where you felt proud of yourself.",
        "Describe a recent moment when you felt disappointed or let down.",
        "Are there any emotions you feel you need to let go of? Why?",
        "What are your goals for the next month, and what steps will you take to achieve them?",
        "Write about a habit you’d like to break and why.",
        "Identify a skill you want to learn or improve. What’s your plan to work on it?",
        "Describe a recent experience that took you out of your comfort zone. What did you learn?",
        "What does success mean to you, and how do you measure it in your life?",
        "Write about someone who has positively influenced your life recently.",
        "Describe a conversation that changed your perspective.",
        "How can you strengthen a relationship that's important to you?",
        "Reflect on a relationship that feels strained. What might be the underlying issues?",
        "What qualities do you value most in your friends and family?",
        "Where do you see yourself in five years? Ten years?",
        "What’s one dream you’ve been hesitant to pursue? What’s holding you back?",
        "If money were no object, what would you be doing right now?",
        "What legacy do you hope to leave behind?",
        "Write a letter to your future self.",
        "Imagine a perfect day from morning to night. What would it look like?",
        "If you could invent something that would make life easier, what would it be?",
        "Create a short story about a memorable event from your childhood.",
        "What would you do if you were the ruler of your own country?",
        "Describe your ideal home. What unique features would it have?",
        "What’s a piece of advice you would give to your younger self?",
        "How has your perspective on the world changed in the past year?",
        "If you could have dinner with any person (alive or deceased), who would it be and why?",
        "Write about a book or movie that deeply affected you. What was its impact?",
        "What are some small things that bring you joy?",
        "Reflect on today using five senses: What did you see, hear, touch, smell, and taste?",
        "List all the places you visited today and something interesting about each.",
        "What’s a major news event that happened this week? How do you feel about it?",
        "What’s the most interesting thing you saw on the internet today?",
        "Write about a piece of art (music, painting, film, etc.) that resonated with you recently.",
    ];
    
    public string RandPrompt() {
        Random rnd = new();
        return promptsList[rnd.Next(promptsList.Count)];
    }
}