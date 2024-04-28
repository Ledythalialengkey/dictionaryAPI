import Container from 'react-bootstrap/Container';
import Navtop from './Navtop';
import TableData from './TableData';

function App(){
  return(
    <>
      <Container className='mt-3 p-3'>
          <Navtop/>
          <TableData/>
      </Container>
    </>
  );
}

export default App;
