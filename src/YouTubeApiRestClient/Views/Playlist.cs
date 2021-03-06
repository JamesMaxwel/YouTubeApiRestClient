﻿using System.Runtime.Serialization;

namespace YouTubeApiRestClient.Views
{
    //
    // Summary:
    //     A playlist resource represents a YouTube playlist. A playlist is a collection
    //     of videos that can be viewed sequentially and shared with other users. A playlist
    //     can contain up to 200 videos, and YouTube does not limit the number of playlists
    //     that each user creates. By default, playlists are publicly visible to other users,
    //     but playlists can be public or private. YouTube also uses playlists to identify
    //     special collections of videos for a channel, such as: - uploaded videos - favorite
    //     videos - positively rated (liked) videos - watch history - watch later To be
    //     more specific, these lists are associated with a channel, which is a collection
    //     of a person, group, or company's videos, playlists, and other YouTube information.
    //     You can retrieve the playlist IDs for each of these lists from the channel resource
    //     for a given channel. You can then use the playlistItems.list method to retrieve
    //     any of those lists. You can also add or remove items from those lists by calling
    //     the playlistItems.insert and playlistItems.delete methods.
    [DataContract]
    public class Playlist
    {
        //
        // Summary:
        //     The contentDetails object contains information like video count.
        //[DataMember(Name="contentDetails", EmitDefaultValue = false)]
        //public  PlaylistContentDetails ContentDetails { get; set; }
        
        //
        // Summary:
        //     Etag of this resource.
        [DataMember(Name="etag", EmitDefaultValue = false)]
        public  string ETag { get; set; }
        
        //
        // Summary:
        //     The ID that YouTube uses to uniquely identify the playlist.
        [DataMember(Name="id", EmitDefaultValue = false)]
        public  string Id { get; set; }
        
        //
        // Summary:
        //     Identifies what kind of resource this is. Value: the fixed string "youtube#playlist".
        [DataMember(Name="kind", EmitDefaultValue = false)]
        public  string Kind { get; set; }
        
        //
        // Summary:
        //     The player object contains information that you would use to play the playlist
        //     in an embedded player.
        //[DataMember(Name="player", EmitDefaultValue = false)]
        //public  PlaylistPlayer Player { get; set; }
        
        //
        // Summary:
        //     The snippet object contains basic details about the playlist, such as its title
        //     and description.
        [DataMember(Name="snippet", EmitDefaultValue = false)]
        public  PlaylistSnippet Snippet { get; set; }

        //
        // Summary:
        //     The status object contains status information for the playlist.
        [DataMember(Name="status", EmitDefaultValue = false)]
        public  PlaylistStatus Status { get; set; }
    }
}
