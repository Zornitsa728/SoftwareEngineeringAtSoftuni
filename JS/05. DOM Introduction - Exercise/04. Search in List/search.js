function search() {
   const townsEls = document.getElementById('towns');
   const searchTextEl = document.getElementById('searchText');
   const resultEl = document.getElementById('result');
   
   const searchText = searchTextEl.value;
   const towns = Array.from(townsEls.children);
   let matches = 0;

   for (const town of towns) {
      if (town.textContent.toLowerCase().includes(searchText.toLowerCase())) {
         matches++;
         town.style.textDecoration = 'underline';
         town.style.fontWeight = 'bold';
      } else {
         town.style.textDecoration = 'none';
         town.style.fontWeight = 'normal';
      }
   }

   resultEl.textContent = `${matches} matches found`;
}
