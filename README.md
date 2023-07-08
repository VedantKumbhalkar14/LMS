TASK ANSWER:

const fs = require("fs");

function createBestPracticeList(articles) {
// Combining all best practices from all articles into a single list
let combinedBestPracticeList= [];
let bestPracticesMap = {};

articles.forEach((article, index) => {
const articleId = index + 1;
const bestPractices = getAllBestPractices(article.content, articleId);

bestPractices.forEach((bestPractice) => {
const { heading, explanation } = bestPractice;

// Adding the unique best practice to the combined list
if (!bestPracticesMap[heading]) {
bestPracticesMap[heading] = {
explanation,
articles: [articleId],
};
combinedBestPracticeList.push(heading);
} else {
bestPracticesMap[heading].articles.push(articleId);
}
});
});

// Sorting the combined list 
combinedBestPracticeList.sort((a, b) => {
const articleCountA = bestPracticesMap[a].articles.length;
const articleCountB = bestPracticesMap[b].articles.length;
return articleCountB - articleCountA;
});

// Creating the final list with best practices and article indices
const BPList = combinedBestPracticeList.map((bestPractice) => {
const { explanation, articles } = bestPracticesMap[bestPractice];
return {
bestPractice,
explanation,
articles,
};
});

return BPList;
}

function getAllBestPractices(content, articleId) {
let bestPractices = [];
const practiceSections = content.split("heading1 "); 
// Here "heading1 " is considered as the heading format in above line.

practiceSections.forEach((section) => {
const headingEndIndex = section.indexOf("\n");
if (headingEndIndex !== -1) {
const heading = section.substring(0, headingEndIndex).trim();
const explanation = section.substring(headingEndIndex).trim();

bestPractices.push({
heading,
explanation,
articleId,
});
}
});

return bestPractices;
}

const practiceList = createBestPracticeList(articles);
fs.writeFile("BestPracticeFile.txt", JSON.stringify(practiceList), (err) => {
    if (!err) {
        console.log("Best Practice File created successfully!")
    }
    else {
        console.log(err.message);
    }
})






Name: Vedant Kumbhalkar
