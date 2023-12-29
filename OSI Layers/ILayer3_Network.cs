namespace CyberSimulator.OSI_Layers;

/*
 * The network layer is responsible for managing the routing of data across multiple networks.
 * Its main function is providing logical addressing and routing services.
 * When it receives data from the data link layer it encapsulates it into packets which are then routed.
 * The network layer also provides services such as fragmentation and reassembly with MTU (Maximum Transmission Unit) sizes.
 * It also provides QOS and congestion control
 */

// The network layer uses the following technologies:
// IP (Internet Protocol)
// ICMP (Internet Control Message Protocol)
// ARP (Address Resolution Protocol)\
// OSPF (Open Shortest Path First)
// BGP (Border Gateway Protocol)
// IPSEC (Internet Protocol Security)

public interface ILayer3Network
{
    
}