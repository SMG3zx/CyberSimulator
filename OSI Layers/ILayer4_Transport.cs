namespace CyberSimulator.OSI_Layers;

/*
 * The transport layer provides end to end communication between applications of different endpoints.
 * Its main function is to ensure that data is transferred reliably and efficiently between endpoints.
 * This function is achieved by using 2 main protocols: TCP and UDP.
 * TCP being the connection oriented side using a 3 way handshake.
 * UDP being the connectionless protocol with less overhead, aimed for fast paced comms where packet loss is not detrimental.
 */

public interface ILayer4Transport
{
    
}