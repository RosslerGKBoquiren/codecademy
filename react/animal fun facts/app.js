import { animals } from './animals';
import React from 'react';
import { createRoot } from 'react-dom/client';

const displayFact = (e) => {
  const animalName = e.target.alt;
  const animalFacts = animals[animalName].facts;
  const randomIndex = Math.floor(Math.random() * animalFacts.length);
  const funFact = animalFacts[randomIndex];
  document.getElementById("fact").innerHTML = funFact;
};

const images = [];
for (const animal in animals) {
  images.push(
    <img 
      key={animal}
      className="animal"
      alt={animal}
      src={animals[animal].image}
      aria-label={animal}
      role="button" 
      onClick={displayFact}
    />
  );
}
const container = document.getElementById("app");
const root = createRoot(container);

const title = "";
const background = <img className="background" alt="ocean" src="/images/ocean.jpg" />

const animalFacts = (
  <div>
    {background}
    <div className="animals">{images}</div>
    <h1>{title === "" ? 'Click an animal for a fun fact' : title}</h1>
    <p id="fact"></p>
  </div>
);

root.render(animalFacts);

