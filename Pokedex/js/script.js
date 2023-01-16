//initial fetch of pokeapi and then calling displayPokemon function, using the value from the search bar to call 
const fetchPokemon = () => {
    let name = document.querySelector(".search-bar").value;
    let url ="https://pokeapi.co/api/v2/pokemon/" + name;
    fetch(url)
    .then( res => {
        return res.json();
    })
    .then( data => {
        this.DisplayPokemon(data);
    })
};


//function to display pokemon data
function DisplayPokemon(data) {

    //updating length of stat bars
        let hpWidth = data.stats[0].base_stat;
        document.getElementById("hp-bar").style.width = hpWidth.toString() + "px";

        let attackWidth = data.stats[1].base_stat;
        document.getElementById("attack-bar").style.width = attackWidth.toString() + "px";

        let defenseWidth = data.stats[2].base_stat;
        document.getElementById("defense-bar").style.width = defenseWidth.toString() + "px";

        let specAttackWidth = data.stats[3].base_stat;
        document.getElementById("spec-attack-bar").style.width = specAttackWidth.toString() + "px";

        let specDefenseWidth = data.stats[4].base_stat;
        document.getElementById("spec-defense-bar").style.width = specDefenseWidth.toString() + "px";

        let speedWidth = data.stats[5].base_stat;
        document.getElementById("speed-bar").style.width = speedWidth.toString() + "px";

    //updating text to show pokemon stats
        document.querySelector(".name").innerText = data.name;
        document.querySelector(".sprite").src = data.sprites["front_default"];
        document.querySelector(".hp").innerText = "HP: " +  data.stats[0].base_stat;
        document.querySelector(".attack").innerText = "Attack: " +  data.stats[1].base_stat;
        document.querySelector(".defense").innerText = "Defense: " +  data.stats[2].base_stat;
        document.querySelector(".spec-attack").innerText = "Special Attack: " +  data.stats[3].base_stat;
        document.querySelector(".spec-def").innerText = "Special Defense: " +  data.stats[4].base_stat;
        document.querySelector(".speed").innerText = "Speed: " +  data.stats[5].base_stat;

    //if pokemon has more than one type show both otherwise only show one
        if(data.types.length > 1) {
            document.querySelector(".type").innerText = data.types[0].type.name + " " + data.types[1].type.name;
        }
        else {
            document.querySelector(".type").innerText = data.types[0].type.name;
        }

}


//fetching pokemon once search button is clicked
document.querySelector(".search-button").addEventListener("click", function () {
    fetchPokemon();
});

//fetching pokemon if enter is pressed
document.querySelector(".search-bar").addEventListener("keyup", function(event) {
    if(event.key == "Enter") {
        fetchPokemon();
    }
})

const NUM_POKEMON = 890;

//function to generate random pokemon with an api call based on a random number, call is activated when onclick event from html occurs
function GenerateRandom() {
    const fetchRandomPokemon = () => {
        let index = Math.floor(Math.random() * NUM_POKEMON);
        let url ="https://pokeapi.co/api/v2/pokemon/" + index.toString();
        fetch(url)
        .then( res => {
            return res.json();
        })
        .then( data => {
            this.DisplayPokemon(data);
        })
    };
    
    fetchRandomPokemon();
}


//function to generate a random pokemon, create image element, and store the pokemons ID to use later.
async function getRandomPokemon() {

  const pokemonId = Math.floor(Math.random() * NUM_POKEMON) + 1;

  const pokemonUrl = `https://pokeapi.co/api/v2/pokemon/${pokemonId}/`;
  const response = await fetch(pokemonUrl);
  const pokemon = await response.json();

  const spriteUrl = pokemon.sprites.front_default;

  const imgElement = document.createElement('img');
  imgElement.src = spriteUrl;
  imgElement.dataset.pokemonId = pokemonId;

  return imgElement;
}


//slideshow function
async function showSlideshow() {

  const container = document.getElementById('slideshow');

  // Setting styles of the 'slideshow'container
  container.style.display = 'flex';
  container.style.width = '500px'; 
  container.style.height = '125px';
  container.style.margin = '10px auto';

  // creating array to show pokemon and adding each random pokemon to array
  let slides = [];
  for (let i = 0; i < 4; i++) {
    slides.push(await getRandomPokemon());
  }



  // Adding the pokemon('slides') to the container and a click event for each pokemon in slideshow to display information once clicked using pokemonId from before
    slides.forEach(slide => {
    container.appendChild(slide); 

    slide.addEventListener('click', () => {

        const ClickedSlideShow = () => {
            let index = slide.dataset.pokemonId;
            let url ="https://pokeapi.co/api/v2/pokemon/" + index.toString();
            fetch(url)
            .then( res => {
                return res.json();
            })
            .then( data => {
                this.DisplayPokemon(data);
            })
        };
        
        ClickedSlideShow();
    
    });

    //mouseover and mouseout events to add a hover effect and turn the mouse to a pointer
    slide.addEventListener('mouseover', () => {
        slide.style.cursor = 'pointer';
        slide.style.transform = 'scale(1.2)'
      });

    slide.addEventListener('mouseout', () => {
        slide.style.transform = 'scale(1)'
    });
    
});



  //removing pokemon from slideshow and update with new pokemon after 5s
    setInterval(async () => {

    slides.forEach(slide => container.removeChild(slide));

    slides = [];
    for (let i = 0; i < 4; i++) {
      slides.push(await getRandomPokemon());
    }

   //same as before, adding pokemon to slideshow and different events to make it hoverable and clickable for newly loading pokemon images
    slides.forEach(slide => {
        container.appendChild(slide);
  
        slide.addEventListener('click', () => {

          const ClickedSlideShow = () => {
            let index = slide.dataset.pokemonId;
            let url ="https://pokeapi.co/api/v2/pokemon/" + index.toString();
            fetch(url)
            .then( res => {
                return res.json();
            })
            .then( data => {
                this.DisplayPokemon(data);
            })
        };
        
        ClickedSlideShow();
    
        });

        slide.addEventListener('mouseover', () => {
            slide.style.cursor = 'pointer';
            slide.style.transform = 'scale(1.2)'
          });

        slide.addEventListener('mouseout', () => {
            slide.style.transform = 'scale(1)'
        });
    });

    container.scrollLeft = 0;
  }, 5000);
}


//calling showSlideShow function
showSlideshow();

