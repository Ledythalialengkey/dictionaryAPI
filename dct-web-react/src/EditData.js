import Table from 'react-bootstrap/Table';
import Button from 'react-bootstrap/Button';
import Form from 'react-bootstrap/Form';



function EditData({ handleEditVisibility }){
    return(
        <>
            <h4>Edit Data</h4>
            <Table bordered  responsive className='mt-2'>
                <tbody>
                    <tr>
                        <td><Form.Control type='text' placeholder='indonesia'/></td>
                        <td><Form.Control type='text' placeholder='gorap'/></td>
                        <td><Form.Control type='file' placeholder='audio' controlId="formFile"
                            style={{ width: '150px' }}
                        /></td>
                        <td><Form.Control type='text' placeholder='deskripsi'/></td>
                    </tr>
                </tbody>
                <Button onClick={handleEditVisibility} className='btn-primary border mt-2'>Update</Button>
            </Table>            
        </>
    );
}

export default EditData;