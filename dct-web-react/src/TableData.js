import Container from 'react-bootstrap/Container'
import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';


function TableData(){
    return(
        <>
            <Container className='mt-5'>
            <Button className='btn-sm'>Tambah data</Button>
            <hr/>
            <Table bordered hover responsive>
                <thead>
                    <tr>
                    <th>#</th>
                    <th>Indonesia</th>
                    <th>Gorap</th>
                    <th>Audio</th>
                    <th>Deskripsi</th>
                    <th>Action</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>halo</td>
                        <td>hola</td>
                        <td>afeoc-121ds.mp4</td>
                        <td>lorem ipsum dolor</td>
                        <td>
                            <Button className='btn-dark mx-2 btn-sm'>Edit</Button>
                            <Button className='btn-danger btn-sm'>Hapus</Button>
                        </td>
                    </tr>
                </tbody>
                </Table>
            </Container>
        </>
    );
}

export default TableData;