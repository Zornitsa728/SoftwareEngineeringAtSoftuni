function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const studentInfoELs = document.querySelectorAll('tbody tr');
      const search = document.getElementById('searchField').value;

      for (const studentEl of studentInfoELs) {
         const studentEls = studentEl.querySelectorAll('td');
         let isSelected = false;

         studentEl.classList.remove('select');

         for (const currEl of studentEls) {
            if (currEl.textContent.includes(search)) {
               isSelected = true;
               break;
            }
         }

         if (isSelected) {
            //studentEl.className = 'select';
            studentEl.classList.add('select');
         }
      }

      search = '';
   }
}