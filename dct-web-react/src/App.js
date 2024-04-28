import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Container from 'react-bootstrap/Container';
import Navtop from './Navtop';
import TableData from './TableData';
import { AuthProvider } from './AuthContext';

function App(){
  return(
    <Router>
      <Container className='mt-3 p-3'>
          <Navtop/>
            <Routes>
              <Route exact path="/dashboard" element={<TableData/>} />
            </Routes>            
      </Container>
    </Router>
  );
}



export default App;
